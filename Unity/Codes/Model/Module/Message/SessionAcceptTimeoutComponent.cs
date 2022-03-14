namespace ET
{
    /// <summary>
    /// 计时断开组件
    /// 刚accept的session只持续5秒，必须通过验证，否则断开
    /// </summary>
    public class SessionAcceptTimeoutComponent: Entity, IAwake, IDestroy
    {
        public long Timer;
    }
}