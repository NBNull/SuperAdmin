﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Super.Admin.Localization
{
    public static class AdminLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AdminConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AdminLocalizationConfigurer).GetAssembly(),
                        "Super.Admin.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
