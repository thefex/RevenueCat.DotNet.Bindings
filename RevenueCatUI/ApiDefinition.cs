using System;
using System.ComponentModel.DataAnnotations;
using Foundation;
using ObjCRuntime;
using RevenueCat;
using StoreKit;
using UIKit;

namespace RevenueCatUI
{
	// @interface RCPaywallViewController
	[BaseType(typeof(UIViewController))]
	[DisableDefaultCtor]
	interface RCPaywallViewController
	{ 
		// @property (nonatomic, weak) id<RCPaywallViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering displayCloseButton:(id)displayCloseButton shouldBlockTouchEvents:(id)shouldBlockTouchEvents dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler;
		[Export("initWithOffering:displayCloseButton:shouldBlockTouchEvents:dismissRequestedHandler:")]
		NativeHandle Constructor([NullAllowed] RCOffering offering, NSObject displayCloseButton, NSObject shouldBlockTouchEvents, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);
		 
		// -(void)updateWithOffering:(RCOffering * _Nonnull)offering;
		[Export("updateWithOffering:")]
		void UpdateWithOffering(RCOffering offering);

		// -(void)updateWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier __attribute__((deprecated("use init with Offering instead")));
		[Export("updateWithOfferingIdentifier:")]
		void UpdateWithOfferingIdentifier(string offeringIdentifier);

		// -(void)updateWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext;
		[Export("updateWithOfferingIdentifier:presentedOfferingContext:")]
		void UpdateWithOfferingIdentifier(string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext);

		// -(void)updateWithDisplayCloseButton:(id)displayCloseButton;
		[Export("updateWithDisplayCloseButton:")]
		void UpdateWithDisplayCloseButton(NSObject displayCloseButton);

		// -(void)updateFontWithFontName:(NSString * _Nonnull)fontName;
		[Export("updateFontWithFontName:")]
		void UpdateFontWithFontName(string fontName);

		// -(void)touchesBegan:(id)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesBegan:withEvent:")]
		void TouchesBegan(NSObject touches, [NullAllowed] UIEvent @event);

		// -(void)touchesMoved:(id)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesMoved:withEvent:")]
		void TouchesMoved(NSObject touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(id)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesEnded:withEvent:")]
		void TouchesEnded(NSObject touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(id)touches withEvent:(UIEvent * _Nullable)event;
		[Export("touchesCancelled:withEvent:")]
		void TouchesCancelled(NSObject touches, [NullAllowed] UIEvent @event);
	}

// @interface RCPaywallFooterViewController : RCPaywallViewController
	[BaseType(typeof(RCPaywallViewController))]
	interface RCPaywallFooterViewController
	{
		// -(instancetype _Nonnull)initWithOffering:(RCOffering * _Nullable)offering dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
		[Export("initWithOffering:dismissRequestedHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor([NullAllowed] RCOffering offering, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer)) __attribute__((deprecated("use init with Offering instead")));
		[Export("initWithOfferingIdentifier:dismissRequestedHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string offeringIdentifier, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
		[Export("initWithOfferingIdentifier:presentedOfferingContext:dismissRequestedHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier fontName:(NSString * _Nonnull)fontName dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer)) __attribute__((deprecated("use init with Offering instead")));
		[Export("initWithOfferingIdentifier:fontName:dismissRequestedHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string offeringIdentifier, string fontName, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier presentedOfferingContext:(RCPresentedOfferingContext * _Nullable)presentedOfferingContext fontName:(NSString * _Nonnull)fontName dismissRequestedHandler:(void (^ _Nullable)(RCPaywallViewController * _Nonnull))dismissRequestedHandler __attribute__((objc_designated_initializer));
		[Export("initWithOfferingIdentifier:presentedOfferingContext:fontName:dismissRequestedHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string offeringIdentifier, [NullAllowed] RCPresentedOfferingContext presentedOfferingContext, string fontName, [NullAllowed] Action<RCPaywallViewController> dismissRequestedHandler);
	}

// @protocol RCPaywallViewControllerDelegate
	[Protocol, Model]
	interface RCPaywallViewControllerDelegate
	{
		// @optional -(void)paywallViewControllerDidStartPurchase:(RCPaywallViewController * _Nonnull)controller;
		[Export("paywallViewControllerDidStartPurchase:")]
		void DidStartPurchase(RCPaywallViewController controller);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didStartPurchaseWithPackage:(RCPackage * _Nonnull)package;
		[Export("paywallViewController:didStartPurchaseWithPackage:")]
		void DidStartPurchaseWithPackage(RCPaywallViewController controller, RCPackage package);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
		[Export("paywallViewController:didFinishPurchasingWithCustomerInfo:")]
		void DidFinishPurchasingWithCustomerInfo(RCPaywallViewController controller, RCCustomerInfo customerInfo);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishPurchasingWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo transaction:(RCStoreTransaction * _Nullable)transaction;
		[Export("paywallViewController:didFinishPurchasingWithCustomerInfo:transaction:")]
		void DidFinishPurchasingWithCustomerInfo(RCPaywallViewController controller, RCCustomerInfo customerInfo, [NullAllowed] RCStoreTransaction transaction);

		// @optional -(void)paywallViewControllerDidCancelPurchase:(RCPaywallViewController * _Nonnull)controller;
		[Export("paywallViewControllerDidCancelPurchase:")]
		void DidCancelPurchase(RCPaywallViewController controller);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailPurchasingWithError:(NSError * _Nonnull)error;
		[Export("paywallViewController:didFailPurchasingWithError:")]
		void DidFailPurchasingWithError(RCPaywallViewController controller, NSError error);

		// @optional -(void)paywallViewControllerDidStartRestore:(RCPaywallViewController * _Nonnull)controller;
		[Export("paywallViewControllerDidStartRestore:")]
		void DidStartRestore(RCPaywallViewController controller);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFinishRestoringWithCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
		[Export("paywallViewController:didFinishRestoringWithCustomerInfo:")]
		void DidFinishRestoring(RCPaywallViewController controller, RCCustomerInfo customerInfo);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didFailRestoringWithError:(NSError * _Nonnull)error;
		[Export("paywallViewController:didFailRestoringWithError:")]
		void DidFailRestoring(RCPaywallViewController controller, NSError error);

		// @optional -(void)paywallViewControllerWasDismissed:(RCPaywallViewController * _Nonnull)controller;
		[Export("paywallViewControllerWasDismissed:")]
		void WasDismissed(RCPaywallViewController controller);

		// @optional -(void)paywallViewController:(RCPaywallViewController * _Nonnull)controller didChangeSizeTo:(id)size;
		[Export("paywallViewController:didChangeSizeTo:")]
		void DidChangeSizeTo(RCPaywallViewController controller, NSObject size);
	}
}