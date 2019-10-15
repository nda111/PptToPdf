using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace System.Languages
{
    public sealed class LanguagePack
    {
        #region Data

        public string LanguageName { get; private set; } = null;

        // Toast
        public string Preferences { get; private set; } = null;
        public string Restart { get; private set; } = null;
        public string RestartMessage { get; private set; } = null;
        public string Quit { get; private set; } = null;
        public string QuitMessage { get; private set; } = null;

        public string ConversionComplete { get; private set; } = null;
        public string ConversionFailed { get; private set; } = null;

        // Config
        public string Generic { get; private set; } = null;
        public string Font { get; private set; } = null;
        public string Language { get; private set; } = null;
        public string Drives { get; private set; } = null;
        public string Alert { get; private set; } = null;
        public string Toast { get; private set; } = null;
        public string Opacity { get; private set; } = null;

        public string Default { get; private set; } = null;
        public string DefaultMessage { get; private set; } = null;
        public string Save { get; private set; } = null;
        public string SaveMessage { get; private set; } = null;

        #endregion

        public static LanguagePack FromLanguage(ELanguages language)
        {
            if (presets.ContainsKey(language))
            {
                return presets[language];
            }

            return null;
        }

        private static readonly Dictionary<ELanguages, LanguagePack> presets = new Dictionary<ELanguages, LanguagePack>
        {
            {
                ELanguages.English_US, new LanguagePack()
                {
                    LanguageName = "English (US)",
                    Preferences = "Preferences",
                    Restart  = "Restart",
                    RestartMessage = "Do you want to restart the program?",
                    Quit = "Quit",
                    QuitMessage = "Are you sure want to quit the program?",
                    ConversionComplete  = "Conversion complete",
                    ConversionFailed = "Conversion failed",
                    Generic = "Generic",
                    Font  = "Font",
                    Language = "Language",
                    Drives  = "Drives",
                    Alert = "Alert",
                    Toast = "Toast",
                    Opacity  = "Opacity",
                    Default  = "Default",
                    DefaultMessage  = "Do you want to set your preferences as default?",
                    Save = "Save",
                    SaveMessage = "Do you want to save your preferences?",
                }
            },
            {
                ELanguages.Korean, new LanguagePack()
                {
                    LanguageName = "한국어",
                    Preferences = "환경 설정",
                    Restart  = "다시 시작",
                    RestartMessage = "프로그램을 다시 시작합니다.",
                    Quit = "종료",
                    QuitMessage = "프로그램을 종료합니다.",
                    ConversionComplete  = "변환 성공했습니다",
                    ConversionFailed = "변환 실패했습니다",
                    Generic = "일반",
                    Font  = "글꼴",
                    Language = "언어",
                    Drives  = "저장장치",
                    Alert = "알림",
                    Toast = "팝업 메시지",
                    Opacity  = "불투명도",
                    Default  = "기본값",
                    DefaultMessage  = "기본값으로 되돌립니다.",
                    Save = "저장",
                    SaveMessage = "설정을 저장합니다.",
                }
            },
            {
                ELanguages.Japanese, new LanguagePack()
                {
                    LanguageName = "日本語",
                    Preferences = "環境設定",
                    Restart  = "再起動",
                    RestartMessage = "プログラムを再起動します",
                    Quit = "終了",
                    QuitMessage = "プログラムを終了します",
                    ConversionComplete  = "変換成功",
                    ConversionFailed = "変換失敗",
                    Generic = "一般",
                    Font  = "フォント",
                    Language = "言語",
                    Drives  = "ストレージ",
                    Alert = "通知",
                    Toast = "ポップアップメッセージ",
                    Opacity  = "不透明度",
                    Default  = "デフォルト",
                    DefaultMessage  = "デフォルトに戻します",
                    Save = "保存",
                    SaveMessage = "環境設定を保存します",
                }
            },
            {
                ELanguages.Chinese, new LanguagePack()
                {
                    LanguageName = "简体中文",
                    Preferences = "偏好设定",
                    Restart  = "重新启动",
                    RestartMessage = "重新启动程序",
                    Quit = "终止",
                    QuitMessage = "退出程序",
                    ConversionComplete  = "转换成功",
                    ConversionFailed = "转换失败",
                    Generic = "一般",
                    Font  = "字体",
                    Language = "语言能力",
                    Drives  = "贮藏",
                    Alert = "通知事项",
                    Toast = "弹出消息",
                    Opacity  = "不透明度",
                    Default  = "默认值",
                    DefaultMessage  = "恢复为默认值",
                    Save = "保存到",
                    SaveMessage = "保存您的首选项",
                }
            },
        };
    }
}
