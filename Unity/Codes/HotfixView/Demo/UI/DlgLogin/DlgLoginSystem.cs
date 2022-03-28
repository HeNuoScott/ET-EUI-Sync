using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ET
{
	public static  class DlgLoginSystem
	{

		public static void RegisterUIEvent(this DlgLogin self)
		{
			self.View.E_LoginButton.AddListenerAsync(() => { return self.OnLoginClickHandler();});
		}

		public static void ShowWindow(this DlgLogin self, Entity contextData = null)
		{
			
		}
		
		public static async ETTask OnLoginClickHandler(this DlgLogin self)
		{
			try
			{
				int errorCode =  await LoginHelper.Login(
															self.DomainScene(), 
															ConstValue.LoginAddress, 
															self.View.E_AccountInputField.text, 
															self.View.E_PasswordInputField.text);
				if (errorCode != ErrorCode.ERR_Success)
				{
					Log.Error(errorCode.ToString());
					return;
				}

				// 登录成功 向服务器查询 区服列表
				errorCode = await LoginHelper.GetServerInfos(self.ZoneScene());
				if (errorCode != ErrorCode.ERR_Success)
				{
					Log.Error(errorCode.ToString());
					return;
				}
				
				// 页面跳转
				self.DomainScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_Login);
				self.DomainScene().GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Server);
			}
			catch (Exception e)
			{
				Log.Error(e.ToString());
			}
		}
		
		public static void HideWindow(this DlgLogin self)
		{

		}
		
	}
}
