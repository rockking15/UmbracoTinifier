﻿namespace Tinifier.Core.Infrastructure
{
    public class PackageConstants
    {
        public const string SectionAlias = "tinifier";
        public const string SectionName = "Tinifier";
        public const string SectionIcon = "icon-wand";
        public const string MenuIcon = "umb-settings";
        public const string MenuSettingsIcon = "article";
        public const string TinyPngUrl = "https://api.tinify.com";

        public const string DbSettingsTable = "TinifierUserSettings";
        public const string DbHistoryTable = "TinifierResponseHistory";
        public const string DbStatisticTable = "TinifierImagesStatistic";

        public const string TinyTImageRoute = "/App_Plugins/Tinifier/BackOffice/timages/tinifyDialog.html";
        public const string TinySettingsRoute = "/App_Plugins/Tinifier/BackOffice/timages/edit.html";

        public const string ApiKeyMessage = "ApiKey successfully added!";
        public const string ApiKeyError = "ApiKey not added! Please, fill ApiKey field with correct value";
        public const string AlreadyOptimized = "Picture was optimized before";
        public const string SuccessOptimized = "Picture optimized succesfully";
        public const string NotSupported = "This extension not supported. You can tinify only PNG and JPG files";
        public const string ApiKeyNotFound = "You don`t have ApiKey in settings! Please, go to tinifier section and add ApiKey there!";
    }
}
