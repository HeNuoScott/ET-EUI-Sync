using System.Runtime.InteropServices;
using UnityEditor;
using System;

namespace ET
{
    public static class OpenProject
    {
        [MenuItem("Tools/打开代码/客户端工程VS",false,80)]
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
        [MenuItem("Tools/打开代码/客户端和服务端Rider",false,81)]
        public static void OpenProjectRider()
        {
            string exePath = "";
#if UNITY_EDITOR_OSX
            const string tools = "./Tools";
            UnityEngine.Debug.LogError("暂时没有配置");
#else
            // 家
            const string exePathHome = @"D:\Application\JetBrains Rider 2021.3.3\bin\rider64.exe";
            // 公司
            const string exePathCompany = @"C:\Program Files\JetBrains\JetBrains Rider 2021.3.3\bin\rider64.exe";

            string location = EditorPrefs.GetString("office location", "家");

            if (location == "家") exePath = exePathHome;
            if (location == "公司") exePath = exePathCompany;
            const string args = "..\\Client-Server.sln";
#endif
            ProcessHelper.Run(exePath, args);
        }
        [MenuItem("Tools/打开代码/调整工作环境/当前", false, 82)]
        public static void OfficeLocationCurrent()
        {
            string location = EditorPrefs.GetString("office location", "家");
            UnityEngine.Debug.Log($"当前 工作环境  {location}");
        }
        [MenuItem("Tools/打开代码/调整工作环境/家", false, 83)]
        public static void OfficeLocationHome()
        {
            EditorPrefs.SetString("office location", "家");
            UnityEngine.Debug.Log("工作环境  家  设置成功");
        }
        [MenuItem("Tools/打开代码/调整工作环境/公司", false, 84)]
        public static void OfficeLocationCompany()
        {
            EditorPrefs.SetString("office location", "公司");
            UnityEngine.Debug.Log("工作环境  公司  设置成功");
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
