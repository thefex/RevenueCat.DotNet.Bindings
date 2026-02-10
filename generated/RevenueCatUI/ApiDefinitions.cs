using System;
using Foundation;
using ObjCRuntime;
using RevenueCatUI;
using UIKit;

// @interface RCCustomerCenterViewController
[NoWatch, NoTV, NoMac, iOS (15,0)]
interface RCCustomerCenterViewController
{
	// -(instancetype _Nonnull)initWithDelegate:(id<RCCustomerCenterViewControllerDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
	[Export ("initWithDelegate:")]
	[DesignatedInitializer]
	NativeHandle Constructor ([NullAllowed] RCCustomerCenterViewControllerDelegate @delegate);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewDidDisappear:(id)animated;
	[Export ("viewDidDisappear:")]
	void ViewDidDisappear (NSObject animated);
}

// @protocol RCCustomerCenterViewControllerDelegate
[NoWatch, NoTV, NoMac, iOS (15,0)]
[Protocol, Model]
interface RCCustomerCenterViewControllerDelegate
{
	// @optional -(void)customerCenterViewControllerDidStartRestore:(RCCustomerCenterViewController * _Nonnull)controller;
	[Export ("customerCenterViewControllerDidStartRestore:")]
	void CustomerCenterViewControllerDidStartRestore (RCCustomerCenterViewController controller);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didFinishRestoringWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
	[Export ("customerCenterViewController:didFinishRestoringWithCustomerInfo:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, RCCustomerInfo customerInfo);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didFailRestoringWithError:(NSError * _Nonnull)error;
	[Export ("customerCenterViewController:didFailRestoringWithError:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, NSError error);

	// @optional -(void)customerCenterViewControllerDidShowManageSubscriptions:(RCCustomerCenterViewController * _Nonnull)controller;
	[Export ("customerCenterViewControllerDidShowManageSubscriptions:")]
	void CustomerCenterViewControllerDidShowManageSubscriptions (RCCustomerCenterViewController controller);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didStartRefundRequestForProductId:(NSString * _Nonnull)productId;
	[Export ("customerCenterViewController:didStartRefundRequestForProductId:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, string productId);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didCompleteRefundRequestForProductId:(NSString * _Nonnull)productId withStatus:(enum RCRefundRequestStatus)status;
	[Export ("customerCenterViewController:didCompleteRefundRequestForProductId:withStatus:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, string productId, RCRefundRequestStatus status);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didCompleteFeedbackSurveyWithOptionId:(NSString * _Nonnull)optionId;
	[Export ("customerCenterViewController:didCompleteFeedbackSurveyWithOptionId:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, string optionId);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didSelectChangePlansWithOptionId:(NSString * _Nonnull)optionId;
	[Export ("customerCenterViewController:didSelectChangePlansWithOptionId:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, string optionId);

	// @optional -(void)customerCenterViewController:(RCCustomerCenterViewController * _Nonnull)controller didSelectCustomActionWithIdentifier:(NSString * _Nonnull)actionIdentifier purchaseIdentifier:(NSString * _Nullable)purchaseIdentifier;
	[Export ("customerCenterViewController:didSelectCustomActionWithIdentifier:purchaseIdentifier:")]
	void CustomerCenterViewController (RCCustomerCenterViewController controller, string actionIdentifier, [NullAllowed] string purchaseIdentifier);

	// @optional -(void)customerCenterViewControllerDidSucceedWithPromotionalOffer:(RCCustomerCenterViewController * _Nonnull)controller;
	[Export ("customerCenterViewControllerDidSucceedWithPromotionalOffer:")]
	void CustomerCenterViewControllerDidSucceedWithPromotionalOffer (RCCustomerCenterViewController controller);

	// @optional -(void)customerCenterViewControllerWasDismissed:(RCCustomerCenterViewController * _Nonnull)controller;
	[Export ("customerCenterViewControllerWasDismissed:")]
	void CustomerCenterViewControllerWasDismissed (RCCustomerCenterViewController controller);
}

// @interface RCPaywallViewController
[TV (15,0), Mac (12,0), iOS (15,0)]
interface RCPaywallViewController
{
	[Wrap ("WeakDelegate")]
	[NullAllowed]
	RCPaywallViewControllerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<RCPaywallViewControllerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(void)setCustomVariable:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
	[Export ("setCustomVariable:forKey:")]
	void SetCustomVariable (string value, string key);

	// -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering displayCloseButton:(id)displayCloseButton shouldBlockTouchEvents:(id)shouldBlockTouchEvents dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler;
	[Export ("initWithOffering:displayCloseButton:shouldBlockTouchEvents:dismissRequestedHandler:")]
	NativeHandle Constructor ([NullAllowed] RCOffering offering, NSObject displayCloseButton, NSObject shouldBlockTouchEvents, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	NativeHandle Constructor (NSCoder coder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewWillAppear:(id)animated;
	[Export ("viewWillAppear:")]
	void ViewWillAppear (NSObject animated);

	// -(void)viewDidDisappear:(id)animated;
	[Export ("viewDidDisappear:")]
	void ViewDidDisappear (NSObject animated);

	// -(void)updateWithOffering:(RCOffering * _Nonnull)offering;
	[Export ("updateWithOffering:")]
	void UpdateWithOffering (RCOffering offering);

	// -(void)updateWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier __attribute__((deprecated("use init with Offering instead")));
	[Export ("updateWithOfferingIdentifier:")]
	void UpdateWithOfferingIdentifier (string offeringIdentifier);

	// -(void)updateWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext;
	[Export ("updateWithOfferingIdentifier:presentedOfferingContext:")]
	void UpdateWithOfferingIdentifier (string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext);

	// -(void)updateWithDisplayCloseButton:(id)displayCloseButton;
	[Export ("updateWithDisplayCloseButton:")]
	void UpdateWithDisplayCloseButton (NSObject displayCloseButton);

	// -(void)updateFontWithFontName:(NSString * _Nonnull)fontName;
	[Export ("updateFontWithFontName:")]
	void UpdateFontWithFontName (string fontName);

	// -(void)touchesBegan:(id)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesBegan:withEvent:")]
	void TouchesBegan (NSObject touches, [NullAllowed] UIEvent @event);

	// -(void)touchesMoved:(id)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesMoved:withEvent:")]
	void TouchesMoved (NSObject touches, [NullAllowed] UIEvent @event);

	// -(void)touchesEnded:(id)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesEnded:withEvent:")]
	void TouchesEnded (NSObject touches, [NullAllowed] UIEvent @event);

	// -(void)touchesCancelled:(id)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesCancelled:withEvent:")]
	void TouchesCancelled (NSObject touches, [NullAllowed] UIEvent @event);
	
	// -(id)presentationControllerShouldDismiss:(UIPresentationController * _Nonnull)presentationController __attribute__((warn_unused_result("")));
	[Export ("presentationControllerShouldDismiss:")]
	NSObject PresentationControllerShouldDismiss (UIPresentationController presentationController);

	// -(void)presentationControllerDidAttemptToDismiss:(UIPresentationController * _Nonnull)presentationController;
	[Export ("presentationControllerDidAttemptToDismiss:")]
	void PresentationControllerDidAttemptToDismiss (UIPresentationController presentationController);

	// -(void)presentationControllerWillDismiss:(UIPresentationController * _Nonnull)presentationController;
	[Export ("presentationControllerWillDismiss:")]
	void PresentationControllerWillDismiss (UIPresentationController presentationController);

	// -(void)presentationControllerDidDismiss:(UIPresentationController * _Nonnull)presentationController;
	[Export ("presentationControllerDidDismiss:")]
	void PresentationControllerDidDismiss (UIPresentationController presentationController);
}

// @interface RCPaywallFooterViewController : RCPaywallViewController
[TV (15,0), Mac (12,0), iOS (15,0)]
[BaseType (typeof(RCPaywallViewController))]
interface RCPaywallFooterViewController
{
	// -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
	[Export ("initWithOffering:dismissRequestedHandler:")]
	[DesignatedInitializer]
	NativeHandle Constructor ([NullAllowed] RCOffering offering, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer)) __attribute__((deprecated("use init with Offering instead")));
	[Export ("initWithOfferingIdentifier:dismissRequestedHandler:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string offeringIdentifier, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
	[Export ("initWithOfferingIdentifier:presentedOfferingContext:dismissRequestedHandler:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier fontName:(NSString * _Nonnull)fontName dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer)) __attribute__((deprecated("use init with Offering instead")));
	[Export ("initWithOfferingIdentifier:fontName:dismissRequestedHandler:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string offeringIdentifier, string fontName, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext fontName:(NSString * _Nonnull)fontName dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
	[Export ("initWithOfferingIdentifier:presentedOfferingContext:fontName:dismissRequestedHandler:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext, string fontName, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	NativeHandle Constructor (NSCoder coder);
}
 
// @protocol RCPaywallViewControllerDelegate
[TV (15,0), Mac (12,0), iOS (15,0)]
[Protocol, Model]
interface RCPaywallViewControllerDelegate
{
	// @optional -(void)paywallViewControllerDidStartPurchase:(RCPaywallViewController * _Nonnull)controller;
	[Export ("paywallViewControllerDidStartPurchase:")]
	void PaywallViewControllerDidStartPurchase (RCPaywallViewController controller);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didStartPurchaseWithPackage:(RCPackage * _Nonnull)package;
	[Export ("paywallViewController:didStartPurchaseWithPackage:")]
	void PaywallViewController (RCPaywallViewController controller, RCPackage package);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
	[Export ("paywallViewController:didFinishPurchasingWithCustomerInfo:")]
	void PaywallViewController (RCPaywallViewController controller, RCCustomerInfo customerInfo);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo transaction:(RCStoreTransaction * _Nullable)transaction;
	[Export ("paywallViewController:didFinishPurchasingWithCustomerInfo:transaction:")]
	void PaywallViewController (RCPaywallViewController controller, RCCustomerInfo customerInfo, [NullAllowed] RCStoreTransaction transaction);

	// @optional -(void)paywallViewControllerDidCancelPurchase:(RCPaywallViewController * _Nonnull)controller;
	[Export ("paywallViewControllerDidCancelPurchase:")]
	void PaywallViewControllerDidCancelPurchase (RCPaywallViewController controller);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailPurchasingWithError:(NSError * _Nonnull)error;
	[Export ("paywallViewController:didFailPurchasingWithError:")]
	void PaywallViewController (RCPaywallViewController controller, NSError error);

	// @optional -(void)paywallViewControllerDidStartRestore:(RCPaywallViewController * _Nonnull)controller;
	[Export ("paywallViewControllerDidStartRestore:")]
	void PaywallViewControllerDidStartRestore (RCPaywallViewController controller);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishRestoringWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
	[Export ("paywallViewController:didFinishRestoringWithCustomerInfo:")]
	void PaywallViewController (RCPaywallViewController controller, RCCustomerInfo customerInfo);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailRestoringWithError:(NSError * _Nonnull)error;
	[Export ("paywallViewController:didFailRestoringWithError:")]
	void PaywallViewController (RCPaywallViewController controller, NSError error);

	// @optional -(void)paywallViewControllerWasDismissed:(RCPaywallViewController * _Nonnull)controller;
	[Export ("paywallViewControllerWasDismissed:")]
	void PaywallViewControllerWasDismissed (RCPaywallViewController controller);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didChangeSizeTo:(id)size;
	[Export ("paywallViewController:didChangeSizeTo:")]
	void PaywallViewController (RCPaywallViewController controller, NSObject size);

	// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller willPresentExitOfferController:(RCPaywallViewController * _Nonnull)exitOfferController;
	[Export ("paywallViewController:willPresentExitOfferController:")]
	void PaywallViewController (RCPaywallViewController controller, RCPaywallViewController exitOfferController);
}
