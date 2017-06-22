﻿using System.Linq;
using Tinifier.Core.Models.API;
using Tinifier.Core.Repository.Realization;
using Tinifier.Core.Services.Interfaces;

namespace Tinifier.Core.Services.Realization
{
    public class StatisticService : IStatisticService
    {
        private ImageService _imageService;
        private TStatisticRepository _statisticRepository;

        public StatisticService()
        {
            _statisticRepository = new TStatisticRepository();
            _imageService = new ImageService();
        }

        public TImageStatistic GetStatistic()
        {
            var optimizedImages = _imageService.GetAllOptimizedImages().ToList().Count;
            var totalImages = _imageService.GetAllImages().ToList().Count;

            var tImageStatistic = new TImageStatistic()
            {
                TotalOptimizedImages = optimizedImages,
                TotalOriginalImages = totalImages - optimizedImages
            };

            return tImageStatistic;
        }

        public void UpdateStatistic()
        {
            var statistic = _statisticRepository.GetStatistic();

            if (statistic != null)
            {
                statistic.TotalNumberOfImages = _imageService.GetAllImages().ToList().Count;
                statistic.NumberOfOptimizedImages = _imageService.GetAllOptimizedImages().ToList().Count;
            }

            _statisticRepository.Update(statistic);         
        }
    }
}
