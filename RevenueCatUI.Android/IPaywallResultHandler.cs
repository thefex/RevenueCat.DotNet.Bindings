using Android.Runtime;
using AndroidX.Activity.Result;
using Java.Interop;
using Object = Java.Lang.Object;

namespace Com.Revenuecat.Purchases.UI.Revenuecatui.Activity; 
    

public partial interface IPaywallResultHandler
{
    // Metadata.xml XPath method reference: path="/api/package[@name='com.revenuecat.purchases.ui.revenuecatui.activity']/interface[@name='PaywallResultHandler']/method[@name='onActivityResult' and count(parameter)=1 and parameter[1][@type='com.revenuecat.purchases.ui.revenuecatui.activity.PaywallResult']]"
    [Register ("onActivityResult", "(Lcom/revenuecat/purchases/ui/revenuecatui/activity/PaywallResult;)V", "GetOnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult_Handler:Com.Revenuecat.Purchases.UI.Revenuecatui.Activity.IPaywallResultHandlerInvoker, RevenueCatUI.Android")]
    void OnActivityResult (global::Com.Revenuecat.Purchases.UI.Revenuecatui.Activity.PaywallResult? result);
}

internal partial class IPaywallResultHandlerInvoker : IPaywallResultHandler
{

		static Delegate? cb_onActivityResult_OnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult__V;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult_Handler ()
		{
			return cb_onActivityResult_OnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult__V ??= new _JniMarshal_PPL_V (n_OnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult_);
		}

		[global::System.Diagnostics.DebuggerDisableUserUnhandledExceptions]
		static void n_OnActivityResult_Lcom_revenuecat_purchases_ui_revenuecatui_activity_PaywallResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			if (!global::Java.Interop.JniEnvironment.BeginMarshalMethod (jnienv, out var __envp, out var __r))
				return;

			try {
				var __this = global::Java.Lang.Object.GetObject<global::Com.Revenuecat.Purchases.UI.Revenuecatui.Activity.IPaywallResultHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var result = global::Java.Lang.Object.GetObject<global::Com.Revenuecat.Purchases.UI.Revenuecatui.Activity.PaywallResult> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnActivityResult (result);
			} catch (global::System.Exception __e) {
				__r.OnUserUnhandledException (ref __envp, __e);
			} finally {
				global::Java.Interop.JniEnvironment.EndMarshalMethod (ref __envp);
			}
		}
#pragma warning restore 0169

		public unsafe void OnActivityResult (global::Com.Revenuecat.Purchases.UI.Revenuecatui.Activity.PaywallResult? result)
		{
			const string __id = "onActivityResult.(Lcom/revenuecat/purchases/ui/revenuecatui/activity/PaywallResult;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object) result).Handle);
				_members_com_revenuecat_purchases_ui_revenuecatui_activity_PaywallResultHandler.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (result);
			}
		}
}