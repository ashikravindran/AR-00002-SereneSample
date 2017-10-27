/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace AR_00002_SereneSample.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('AR_00002_SereneSample');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}