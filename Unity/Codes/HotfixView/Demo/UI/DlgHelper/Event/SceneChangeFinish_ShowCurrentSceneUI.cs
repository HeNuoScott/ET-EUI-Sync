namespace ET
{
    
    public class SceneChangeFinish_ShowCurrentSceneUI: AEvent<EventType.SceneChangeFinish>
    {
        protected override async ETTask Run(EventType.SceneChangeFinish args)
        {
            // 在这个案例中 没有使用到WindowID_Lobby这个界面
            //args.ZoneScene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Lobby);
            // 直接从角色页面跳转的  所以关闭角色页面
            args.ZoneScene.GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Roles);
            await ETTask.CompletedTask;
        }
    }
    
}