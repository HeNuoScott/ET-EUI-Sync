using System.Runtime.InteropServices;
using UnityEditor;
using System;

namespace ET
{
    public static class OpenProject
    {
        [MenuItem("Tools/Open C# Project By VS",false,98)]
        public static void OpenProjectVS()
        {
#if UNITY_EDITOR_OSX
            const string tools = "./Tools";
            UnityEngine.Debug.LogError("暂时没有配置");
#else
            const string exePath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
            const string args = ".\\Unity.sln";
#endif
            ProcessHelper.Run(exePath, args);
        }
        [MenuItem("Tools/Open C# Project By Rider",false,99)]
        public static void OpenProjectRider()
        {
#if UNITY_EDITOR_OSX
            const string tools = "./Tools";
            UnityEngine.Debug.LogError("暂时没有配置");
#else
            // 家
            //const string exePath = @"D:\Application\JetBrains Rider 2021.3.3\bin\rider64.exe";
            // 公司
            const string exePath = @"C:\Program Files\JetBrains\JetBrains Rider 2021.3.3\bin\rider64.exe";
            const string args = "..\\Client-Server.sln";
#endif
            ProcessHelper.Run(exePath, args);
        }
        
        [MenuItem("Tools/打开学习笔记",false,100)]
        public static void OpenProjectXmind()
        {
#if UNITY_EDITOR_OSX
            const string tools = "./Tools";
            UnityEngine.Debug.LogError("暂时没有配置");
#else
            const string exePath = @"D:\Application\XMind ZEN\XMind.exe";
            const string args = "..\\ET框架学习笔记.xmind";
#endif
            ProcessHelper.Run(exePath, args);
        }
    }

}
