using System;

namespace BetterGenshinImpact.Model;

public enum HotKeyTypeEnum
{
    GlobalRegister, // 全局热键
    KeyboardMonitor, // 键盘监听
}

public static class HotKeyTypeEnumExtension
{
    public static string ToChineseName(this HotKeyTypeEnum type)
    {
        return type switch
        {
            HotKeyTypeEnum.GlobalRegister => "Global",
            HotKeyTypeEnum.KeyboardMonitor => "Mouse and Keyboard",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }
}