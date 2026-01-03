using System;
using System.ComponentModel.DataAnnotations;
using Foundation;
using ObjCRuntime;
using RevenueCat;
using StoreKit;

namespace RevenueCat;

// @interface RCAttribution
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCAttribution
	{
		// -(void)enableAdServicesAttributionTokenCollection;
		[Export("enableAdServicesAttributionTokenCollection")]
		void EnableAdServicesAttributionTokenCollection();
	
		// -(void)collectDeviceIdentifiers;
		[Export("collectDeviceIdentifiers")]
		void CollectDeviceIdentifiers();

		// -(void)setAttributes:(id)attributes;
		[Export("setAttributes:")]
		void SetAttributes(NSObject attributes);

		// -(void)setEmail:(NSString * _Nullable)email;
		[Export("setEmail:")]
		void SetEmail([NullAllowed] string email);

		// -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber;
		[Export("setPhoneNumber:")]
		void SetPhoneNumber([NullAllowed] string phoneNumber);

		// -(void)setDisplayName:(NSString * _Nullable)displayName;
		[Export("setDisplayName:")]
		void SetDisplayName([NullAllowed] string displayName);

		// -(void)setPushToken:(NSData * _Nullable)pushToken;
		[Export("setPushToken:")]
		void SetPushToken([NullAllowed] NSData pushToken);

		// -(void)setPushTokenString:(NSString * _Nullable)pushToken;
		[Export("setPushTokenString:")]
		void SetPushTokenString([NullAllowed] string pushToken);

		// -(void)setAdjustID:(NSString * _Nullable)adjustID;
		[Export("setAdjustID:")]
		void SetAdjustID([NullAllowed] string adjustID);

		// -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID;
		[Export("setAppsflyerID:")]
		void SetAppsflyerID([NullAllowed] string appsflyerID);

		// -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID;
		[Export("setFBAnonymousID:")]
		void SetFBAnonymousID([NullAllowed] string fbAnonymousID);

		// -(void)setMparticleID:(NSString * _Nullable)mparticleID;
		[Export("setMparticleID:")]
		void SetMparticleID([NullAllowed] string mparticleID);

		// -(void)setOnesignalID:(NSString * _Nullable)onesignalID;
		[Export("setOnesignalID:")]
		void SetOnesignalID([NullAllowed] string onesignalID);

		// -(void)setOnesignalUserID:(NSString * _Nullable)onesignalUserID;
		[Export("setOnesignalUserID:")]
		void SetOnesignalUserID([NullAllowed] string onesignalUserID);

		// -(void)setAirshipChannelID:(NSString * _Nullable)airshipChannelID;
		[Export("setAirshipChannelID:")]
		void SetAirshipChannelID([NullAllowed] string airshipChannelID);

		// -(void)setCleverTapID:(NSString * _Nullable)cleverTapID;
		[Export("setCleverTapID:")]
		void SetCleverTapID([NullAllowed] string cleverTapID);
		
		// -(void)setAirbridgeDeviceID:(NSString * _Nullable)airbridgeDeviceID;
		[Export ("setAirbridgeDeviceID:")]
		void SetAirbridgeDeviceID ([NullAllowed] string airbridgeDeviceID);

		// -(void)setKochavaDeviceID:(NSString * _Nullable)kochavaDeviceID;
		[Export("setKochavaDeviceID:")]
		void SetKochavaDeviceID([NullAllowed] string kochavaDeviceID);

		// -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID;
		[Export("setMixpanelDistinctID:")]
		void SetMixpanelDistinctID([NullAllowed] string mixpanelDistinctID);

		// -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID;
		[Export("setFirebaseAppInstanceID:")]
		void SetFirebaseAppInstanceID([NullAllowed] string firebaseAppInstanceID);

		// -(void)setTenjinAnalyticsInstallationID:(NSString * _Nullable)tenjinAnalyticsInstallationID;
		[Export("setTenjinAnalyticsInstallationID:")]
		void SetTenjinAnalyticsInstallationID([NullAllowed] string tenjinAnalyticsInstallationID);

		// -(void)setPostHogUserID:(NSString * _Nullable)postHogUserID;
		[Export("setPostHogUserID:")]
		void SetPostHogUserID([NullAllowed] string postHogUserID);

		// -(void)setAmplitudeUserID:(NSString * _Nullable)amplitudeUserID;
		[Export ("setAmplitudeUserID:")]
		void SetAmplitudeUserID ([NullAllowed] string amplitudeUserID);

		// -(void)setAmplitudeDeviceID:(NSString * _Nullable)amplitudeDeviceID;
		[Export ("setAmplitudeDeviceID:")]
		void SetAmplitudeDeviceID ([NullAllowed] string amplitudeDeviceID);

		// -(void)setMediaSource:(NSString * _Nullable)mediaSource;
		[Export("setMediaSource:")]
		void SetMediaSource([NullAllowed] string mediaSource);

		// -(void)setCampaign:(NSString * _Nullable)campaign;
		[Export("setCampaign:")]
		void SetCampaign([NullAllowed] string campaign);

		// -(void)setAdGroup:(NSString * _Nullable)adGroup;
		[Export("setAdGroup:")]
		void SetAdGroup([NullAllowed] string adGroup);

		// -(void)setAd:(NSString * _Nullable)installAd;
		[Export("setAd:")]
		void SetAd([NullAllowed] string installAd);

		// -(void)setKeyword:(NSString * _Nullable)keyword;
		[Export("setKeyword:")]
		void SetKeyword([NullAllowed] string keyword);

		// -(void)setCreative:(NSString * _Nullable)creative;
		[Export("setCreative:")]
		void SetCreative([NullAllowed] string creative);
	}
	

// @interface RCConfigurationBuilder
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCConfigurationBuilder
	{
		// -(RCConfigurationBuilder * _Nonnull)withUsesStoreKit2IfAvailable:(id)usesStoreKit2IfAvailable __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use .with(storeKitVersion:) to enable StoreKit 2")));
		[Export("withUsesStoreKit2IfAvailable:")]
		RCConfigurationBuilder WithUsesStoreKit2IfAvailable(NSObject usesStoreKit2IfAvailable);
		
		// -(instancetype _Nonnull)initWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((objc_designated_initializer));
		[Export("initWithAPIKey:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string apiKey);

		// -(RCConfigurationBuilder * _Nonnull)withApiKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
		[Export("withApiKey:")]
		RCConfigurationBuilder WithApiKey(string apiKey);

		// -(RCConfigurationBuilder * _Nonnull)withAppUserID:(NSString * _Nullable)appUserID __attribute__((warn_unused_result("")));
		[Export("withAppUserID:")]
		RCConfigurationBuilder WithAppUserID([NullAllowed] string appUserID);

		// -(RCConfigurationBuilder * _Nonnull)withPurchasesAreCompletedBy:(enum RCPurchasesAreCompletedBy)purchasesAreCompletedBy storeKitVersion:(enum RCStoreKitVersion)storeKitVersion __attribute__((warn_unused_result("")));
		[Export("withPurchasesAreCompletedBy:storeKitVersion:")]
		RCConfigurationBuilder WithPurchasesAreCompletedBy(RCPurchasesAreCompletedBy purchasesAreCompletedBy, RCStoreKitVersion storeKitVersion);

		// -(RCConfigurationBuilder * _Nonnull)withUserDefaults:(NSUserDefaults * _Nonnull)userDefaults __attribute__((warn_unused_result("")));
		[Export("withUserDefaults:")]
		RCConfigurationBuilder WithUserDefaults(NSUserDefaults userDefaults);

		// -(RCConfigurationBuilder * _Nonnull)withDangerousSettings:(RCDangerousSettings * _Nonnull)dangerousSettings __attribute__((warn_unused_result("")));
		[Export("withDangerousSettings:")]
		RCConfigurationBuilder WithDangerousSettings(RCDangerousSettings dangerousSettings);

		// -(RCConfigurationBuilder * _Nonnull)withNetworkTimeout:(id)networkTimeout __attribute__((warn_unused_result("")));
		[Export("withNetworkTimeout:")]
		RCConfigurationBuilder WithNetworkTimeout(NSObject networkTimeout);

		// -(RCConfigurationBuilder * _Nonnull)withStoreKit1Timeout:(id)storeKit1Timeout __attribute__((warn_unused_result("")));
		[Export("withStoreKit1Timeout:")]
		RCConfigurationBuilder WithStoreKit1Timeout(NSObject storeKit1Timeout);

		// -(RCConfigurationBuilder * _Nonnull)withPlatformInfo:(RCPlatformInfo * _Nonnull)platformInfo __attribute__((warn_unused_result("")));
		[Export("withPlatformInfo:")]
		RCConfigurationBuilder WithPlatformInfo(RCPlatformInfo platformInfo);

		// -(RCConfigurationBuilder * _Nonnull)withShowStoreMessagesAutomatically:(id)showStoreMessagesAutomatically __attribute__((warn_unused_result("")));
		[Export("withShowStoreMessagesAutomatically:")]
		RCConfigurationBuilder WithShowStoreMessagesAutomatically(NSObject showStoreMessagesAutomatically);

		// -(RCConfigurationBuilder * _Nonnull)withEntitlementVerificationMode:(enum RCEntitlementVerificationMode)mode __attribute__((warn_unused_result("")));
		[Export("withEntitlementVerificationMode:")]
		RCConfigurationBuilder WithEntitlementVerificationMode(RCEntitlementVerificationMode mode);

		// -(RCConfigurationBuilder * _Nonnull)withDiagnosticsEnabled:(id)diagnosticsEnabled __attribute__((warn_unused_result(""))) __attribute__((availability(watchos, introduced=8.0))) __attribute__((availability(macos, introduced=12.0))) __attribute__((availability(tvos, introduced=15.0))) __attribute__((availability(ios, introduced=15.0)));
		[Export("withDiagnosticsEnabled:")]
		RCConfigurationBuilder WithDiagnosticsEnabled(NSObject diagnosticsEnabled);

		// -(RCConfigurationBuilder * _Nonnull)withStoreKitVersion:(enum RCStoreKitVersion)version __attribute__((warn_unused_result("")));
		[Export("withStoreKitVersion:")]
		RCConfigurationBuilder WithStoreKitVersion(RCStoreKitVersion version);

		// -(RCConfigurationBuilder * _Nonnull)withAutomaticDeviceIdentifierCollectionEnabled:(id)automaticDeviceIdentifierCollectionEnabled __attribute__((warn_unused_result("")));
		[Export ("withAutomaticDeviceIdentifierCollectionEnabled:")]
		RCConfigurationBuilder WithAutomaticDeviceIdentifierCollectionEnabled (NSObject automaticDeviceIdentifierCollectionEnabled);

		// -(RCConfiguration * _Nonnull)build __attribute__((warn_unused_result("")));
		[Export("build")]
		RCConfiguration Build { get; }
	}
	
// @interface RCConfiguration
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCConfiguration
	{
		// +(RCConfigurationBuilder * _Nonnull)builderWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
		[Static]
		[Export("builderWithAPIKey:")]
		RCConfigurationBuilder BuilderWithAPIKey(string apiKey);
	}
	
// @interface RCCustomerInfo
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCCustomerInfo
	{
		// @property (readonly, nonatomic, strong) RCEntitlementInfos * _Nonnull entitlements;
		[Export("entitlements", ArgumentSemantic.Strong)]
		RCEntitlementInfos Entitlements { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable latestExpirationDate;
		[NullAllowed, Export("latestExpirationDate", ArgumentSemantic.Copy)]
		NSDate LatestExpirationDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull requestDate;
		[Export("requestDate", ArgumentSemantic.Copy)]
		NSDate RequestDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull firstSeen;
		[Export("firstSeen", ArgumentSemantic.Copy)]
		NSDate FirstSeen { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull originalAppUserId;
		[Export("originalAppUserId")] string OriginalAppUserId { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable managementURL;
		[NullAllowed, Export("managementURL", ArgumentSemantic.Copy)]
		NSUrl ManagementURL { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
		[NullAllowed, Export("originalPurchaseDate", ArgumentSemantic.Copy)]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable originalApplicationVersion;
		[NullAllowed, Export("originalApplicationVersion")]
		string OriginalApplicationVersion { get; }

		// -(NSDate * _Nullable)expirationDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
		[Export("expirationDateForProductIdentifier:")]
		[return: NullAllowed]
		NSDate ExpirationDateForProductIdentifier(string productIdentifier);

		// -(NSDate * _Nullable)purchaseDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
		[Export("purchaseDateForProductIdentifier:")]
		[return: NullAllowed]
		NSDate PurchaseDateForProductIdentifier(string productIdentifier);

		// -(NSDate * _Nullable)expirationDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
		[Export("expirationDateForEntitlement:")]
		[return: NullAllowed]
		NSDate ExpirationDateForEntitlement(string entitlementIdentifier);

		// -(NSDate * _Nullable)purchaseDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
		[Export("purchaseDateForEntitlement:")]
		[return: NullAllowed]
		NSDate PurchaseDateForEntitlement(string entitlementIdentifier);
		
		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }


	}
	

// @interface RCDangerousSettings
	[BaseType(typeof(NSObject))]
	interface RCDangerousSettings
	{
		// @property (readonly, nonatomic) int autoSyncPurchases;
		[Export("autoSyncPurchases")] int AutoSyncPurchases { get; }

		// @property (readonly, nonatomic) int customEntitlementComputation;
		[Export("customEntitlementComputation")]
		int CustomEntitlementComputation { get; }

		// -(instancetype _Nonnull)initWithAutoSyncPurchases:(id)autoSyncPurchases;
		[Export("initWithAutoSyncPurchases:")]
		NativeHandle Constructor(NSObject autoSyncPurchases);
	}

// @interface RCEntitlementInfo
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCEntitlementInfo
	{
		// @property (readonly, nonatomic) int isActiveInCurrentEnvironment;
		[Export("isActiveInCurrentEnvironment")]
		int IsActiveInCurrentEnvironment { get; }

		// @property (readonly, nonatomic) int isActiveInAnyEnvironment;
		[Export("isActiveInAnyEnvironment")] int IsActiveInAnyEnvironment { get; }
		
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")] string Identifier { get; }

		// @property (readonly, nonatomic) int isActive;
		[Export("isActive")] int IsActive { get; }

		// @property (readonly, nonatomic) int willRenew;
		[Export("willRenew")] int WillRenew { get; }

		// @property (readonly, nonatomic) enum RCPeriodType periodType;
		[Export("periodType")] RCPeriodType PeriodType { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable latestPurchaseDate;
		[NullAllowed, Export("latestPurchaseDate", ArgumentSemantic.Copy)]
		NSDate LatestPurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
		[NullAllowed, Export("originalPurchaseDate", ArgumentSemantic.Copy)]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable expirationDate;
		[NullAllowed, Export("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }

		// @property (readonly, nonatomic) enum RCStore store;
		[Export("store")] RCStore Store { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
		[Export("productIdentifier")] string ProductIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable productPlanIdentifier;
		[NullAllowed, Export("productPlanIdentifier")]
		string ProductPlanIdentifier { get; }

		// @property (readonly, nonatomic) int isSandbox;
		[Export("isSandbox")] int IsSandbox { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable unsubscribeDetectedAt;
		[NullAllowed, Export("unsubscribeDetectedAt", ArgumentSemantic.Copy)]
		NSDate UnsubscribeDetectedAt { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable billingIssueDetectedAt;
		[NullAllowed, Export("billingIssueDetectedAt", ArgumentSemantic.Copy)]
		NSDate BillingIssueDetectedAt { get; }

		// @property (readonly, nonatomic) enum RCPurchaseOwnershipType ownershipType;
		[Export("ownershipType")] RCPurchaseOwnershipType OwnershipType { get; }

		// @property (readonly, nonatomic) enum RCVerificationResult verification;
		[Export("verification")] RCVerificationResult Verification { get; }


		 
		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
	}



// @interface RCEntitlementInfos
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCEntitlementInfos
	{
		// -(RCEntitlementInfo * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCEntitlementInfo ObjectForKeyedSubscript(string key);

		// @property (readonly, nonatomic) enum RCVerificationResult verification;
		[Export("verification")] RCVerificationResult Verification { get; }
		
	}
	

// @interface RCIntroEligibility
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCIntroEligibility
	{
		// @property (readonly, nonatomic) enum RCIntroEligibilityStatus status;
		[Export("status")] RCIntroEligibilityStatus Status { get; }
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
	}


// @interface RCNonSubscriptionTransaction
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCNonSubscriptionTransaction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
		[Export("productIdentifier")] string ProductIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
		[Export("purchaseDate", ArgumentSemantic.Copy)]
		NSDate PurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
		[Export("transactionIdentifier")] string TransactionIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull storeTransactionIdentifier;
		[Export("storeTransactionIdentifier")] string StoreTransactionIdentifier { get; }

		// @property (readonly, nonatomic) enum RCStore store;
		[Export("store")] RCStore Store { get; }

		// @property (readonly, nonatomic, strong) RCProductPaidPrice * _Nullable price;
		[NullAllowed, Export("price", ArgumentSemantic.Strong)]
		RCProductPaidPrice Price { get; }

		// @property (readonly, nonatomic) int isSandbox;
		[Export("isSandbox")] int IsSandbox { get; }
		
	}

// @interface RCOffering
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCOffering
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")] string Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull serverDescription;
		[Export("serverDescription")] string ServerDescription { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable lifetime;
		[NullAllowed, Export("lifetime", ArgumentSemantic.Strong)]
		RCPackage Lifetime { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable annual;
		[NullAllowed, Export("annual", ArgumentSemantic.Strong)]
		RCPackage Annual { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable sixMonth;
		[NullAllowed, Export("sixMonth", ArgumentSemantic.Strong)]
		RCPackage SixMonth { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable threeMonth;
		[NullAllowed, Export("threeMonth", ArgumentSemantic.Strong)]
		RCPackage ThreeMonth { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable twoMonth;
		[NullAllowed, Export("twoMonth", ArgumentSemantic.Strong)]
		RCPackage TwoMonth { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable monthly;
		[NullAllowed, Export("monthly", ArgumentSemantic.Strong)]
		RCPackage Monthly { get; }

		// @property (readonly, nonatomic, strong) RCPackage * _Nullable weekly;
		[NullAllowed, Export("weekly", ArgumentSemantic.Strong)]
		RCPackage Weekly { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable webCheckoutUrl;
		[NullAllowed, Export("webCheckoutUrl", ArgumentSemantic.Copy)]
		NSUrl WebCheckoutUrl { get; }
		
		// -(RCPackage * _Nullable)packageWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
		[Export("packageWithIdentifier:")]
		[return: NullAllowed]
		RCPackage PackageWithIdentifier([NullAllowed] string identifier);

		// -(RCPackage * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCPackage ObjectForKeyedSubscript(string key);

		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier serverDescription:(NSString * _Nonnull)serverDescription metadata:(id)metadata availablePackages:(id)availablePackages webCheckoutUrl:(NSURL * _Nullable)webCheckoutUrl;
		[Export("initWithIdentifier:serverDescription:metadata:availablePackages:webCheckoutUrl:")]
		NativeHandle Constructor(string identifier, string serverDescription, NSObject metadata, NSObject availablePackages, [NullAllowed] NSUrl webCheckoutUrl);
	}

// @interface RCOfferings
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCOfferings
	{
		// @property (readonly, nonatomic, strong) RCOffering * _Nullable current;
		[NullAllowed, Export("current", ArgumentSemantic.Strong)]
		RCOffering Current { get; }
		
		// -(RCOffering * _Nullable)offeringWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
		[Export("offeringWithIdentifier:")]
		[return: NullAllowed]
		RCOffering OfferingWithIdentifier([NullAllowed] string identifier);

		// -(RCOffering * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCOffering ObjectForKeyedSubscript(string key);



		// -(RCOffering * _Nullable)currentOfferingForPlacement:(NSString * _Nonnull)placementIdentifier __attribute__((warn_unused_result("")));
		[Export("currentOfferingForPlacement:")]
		[return: NullAllowed]
		RCOffering CurrentOfferingForPlacement(string placementIdentifier);
	}
	

// @interface RCPackage
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPackage
	{
		// +(NSString * _Nullable)stringFrom:(enum RCPackageType)packageType __attribute__((warn_unused_result("")));
		[Static]
		[Export("stringFrom:")]
		[return: NullAllowed]
		string StringFrom(RCPackageType packageType);

		// +(enum RCPackageType)packageTypeFrom:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export("packageTypeFrom:")]
		RCPackageType PackageTypeFrom(string @string);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull offeringIdentifier;
		[Export("offeringIdentifier")] string OfferingIdentifier { get; }
		
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")] string Identifier { get; }

		// @property (readonly, nonatomic) enum RCPackageType packageType;
		[Export("packageType")] RCPackageType PackageType { get; }

		// @property (readonly, nonatomic, strong) RCStoreProduct * _Nonnull storeProduct;
		[Export("storeProduct", ArgumentSemantic.Strong)]
		RCStoreProduct StoreProduct { get; }

		// @property (readonly, nonatomic, strong) RCPresentedOfferingContext * _Nonnull presentedOfferingContext;
		[Export("presentedOfferingContext", ArgumentSemantic.Strong)]
		RCPresentedOfferingContext PresentedOfferingContext { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
		[Export("localizedPriceString")] string LocalizedPriceString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
		[NullAllowed, Export("localizedIntroductoryPriceString")]
		string LocalizedIntroductoryPriceString { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable webCheckoutUrl;
		[NullAllowed, Export("webCheckoutUrl", ArgumentSemantic.Copy)]
		NSUrl WebCheckoutUrl { get; }

		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier packageType:(enum RCPackageType)packageType storeProduct:(RCStoreProduct * _Nonnull)storeProduct offeringIdentifier:(NSString * _Nonnull)offeringIdentifier webCheckoutUrl:(NSURL * _Nullable)webCheckoutUrl;
		[Export("initWithIdentifier:packageType:storeProduct:offeringIdentifier:webCheckoutUrl:")]
		NativeHandle Constructor(string identifier, RCPackageType packageType, RCStoreProduct storeProduct, string offeringIdentifier, [NullAllowed] NSUrl webCheckoutUrl);

		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier packageType:(enum RCPackageType)packageType storeProduct:(RCStoreProduct * _Nonnull)storeProduct presentedOfferingContext:(RCPresentedOfferingContext * _Nonnull)presentedOfferingContext webCheckoutUrl:(NSURL * _Nullable)webCheckoutUrl __attribute__((objc_designated_initializer));
		[Export("initWithIdentifier:packageType:storeProduct:presentedOfferingContext:webCheckoutUrl:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string identifier, RCPackageType packageType, RCStoreProduct storeProduct, RCPresentedOfferingContext presentedOfferingContext, [NullAllowed] NSUrl webCheckoutUrl);
		
		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
	}
	

// @interface RCPresentedOfferingContext
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPresentedOfferingContext
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull offeringIdentifier;
		[Export("offeringIdentifier")] string OfferingIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable placementIdentifier;
		[NullAllowed, Export("placementIdentifier")]
		string PlacementIdentifier { get; }

		// @property (readonly, nonatomic, strong) RCTargetingContext * _Nullable targetingContext;
		[NullAllowed, Export("targetingContext", ArgumentSemantic.Strong)]
		RCTargetingContext TargetingContext { get; }

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier placementIdentifier:(NSString * _Nullable)placementIdentifier targetingContext:(RCTargetingContext * _Nullable)targetingContext __attribute__((objc_designated_initializer));
		[Export("initWithOfferingIdentifier:placementIdentifier:targetingContext:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string offeringIdentifier, [NullAllowed] string placementIdentifier, [NullAllowed] RCTargetingContext targetingContext);

		// -(instancetype _Nonnull)initWithOfferingIdentifier:(NSString * _Nonnull)offeringIdentifier;
		[Export("initWithOfferingIdentifier:")]
		NativeHandle Constructor(string offeringIdentifier);
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
	}

// @interface RCTargetingContext
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCTargetingContext
	{
		// @property (readonly, nonatomic) int revision;
		[Export("revision")] int Revision { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull ruleId;
		[Export("ruleId")] string RuleId { get; }

		// -(instancetype _Nonnull)initWithRevision:(id)revision ruleId:(NSString * _Nonnull)ruleId __attribute__((objc_designated_initializer));
		[Export("initWithRevision:ruleId:")]
		[DesignatedInitializer]
		NativeHandle Constructor(NSObject revision, string ruleId);
	}

// @interface RCProductPaidPrice
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCProductPaidPrice
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull currency;
		[Export("currency")] string Currency { get; }

		// @property (readonly, nonatomic) double amount;
		[Export("amount")] double Amount { get; }
		
		// @property (readonly, copy, nonatomic) NSString * _Nonnull formatted;
		[Export ("formatted")]
		string Formatted { get; }
	}

// @interface RCPromotionalOffer
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPromotionalOffer
	{
		// @property (readonly, nonatomic, strong) RCStoreProductDiscount * _Nonnull discount;
		[Export("discount", ArgumentSemantic.Strong)]
		RCStoreProductDiscount Discount { get; }

		// @property (readonly, nonatomic, strong) RCPromotionalOfferSignedData * _Nonnull signedData;
		[Export("signedData", ArgumentSemantic.Strong)]
		RCPromotionalOfferSignedData SignedData { get; }
	}
	

// @interface RCPromotionalOfferSignedData
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPromotionalOfferSignedData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")] string Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull keyIdentifier;
		[Export("keyIdentifier")] string KeyIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSUUID * _Nonnull nonce;
		[Export("nonce", ArgumentSemantic.Copy)]
		NSUuid Nonce { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull signature;
		[Export("signature")] string Signature { get; }

		// @property (readonly, nonatomic) int timestamp;
		[Export("timestamp")] int Timestamp { get; }
		
	}

// @interface RCPurchaseParams
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPurchaseParams
	{
	}

// @interface RCPurchaseParamsBuilder
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPurchaseParamsBuilder
	{
		// -(instancetype _Nonnull)initWithPackage:(RCPackage * _Nonnull)package __attribute__((objc_designated_initializer));
		[Export("initWithPackage:")]
		[DesignatedInitializer]
		NativeHandle Constructor(RCPackage package);

		// -(instancetype _Nonnull)initWithProduct:(RCStoreProduct * _Nonnull)product __attribute__((objc_designated_initializer));
		[Export("initWithProduct:")]
		[DesignatedInitializer]
		NativeHandle Constructor(RCStoreProduct product);

		// -(instancetype _Nonnull)withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer __attribute__((warn_unused_result("")));
		[Export("withPromotionalOffer:")]
		RCPurchaseParamsBuilder WithPromotionalOffer(RCPromotionalOffer promotionalOffer);

		// -(instancetype _Nonnull)withWinBackOffer:(RCWinBackOffer * _Nonnull)winBackOffer __attribute__((warn_unused_result(""))) __attribute__((availability(visionos, introduced=2.0))) __attribute__((availability(watchos, introduced=11.0))) __attribute__((availability(tvos, introduced=18.0))) __attribute__((availability(macos, introduced=15.0))) __attribute__((availability(ios, introduced=18.0)));
		[Export("withWinBackOffer:")]
		RCPurchaseParamsBuilder WithWinBackOffer(RCWinBackOffer winBackOffer);

		// -(RCPurchaseParams * _Nonnull)build __attribute__((warn_unused_result("")));
		[Export("build")]
		RCPurchaseParams Build { get; }
	}


// @protocol RCPurchasesType
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface RCPurchasesType
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull appUserID;
		[Abstract] [Export("appUserID")] string AppUserID { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable storeFrontCountryCode;
		[Abstract]
		[NullAllowed, Export("storeFrontCountryCode")]
		string StoreFrontCountryCode { get; }

		// @required @property (readonly, nonatomic) int isAnonymous;
		[Abstract] [Export("isAnonymous")] int IsAnonymous { get; }

		// @required @property (nonatomic) enum RCPurchasesAreCompletedBy purchasesAreCompletedBy;
		[Abstract]
		[Export("purchasesAreCompletedBy", ArgumentSemantic.Assign)]
		RCPurchasesAreCompletedBy PurchasesAreCompletedBy { get; set; }

		[Wrap("WeakDelegate"), Abstract]
		[NullAllowed]
		RCPurchasesDelegate Delegate { get; set; }

		// @required @property (nonatomic, strong) id<RCPurchasesDelegate> _Nullable delegate;
		[Abstract]
		[NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)getStorefrontWithCompletion:(void (^ _Nonnull)(RCStorefront * _Nullable))completion;
		[Abstract]
		[Export("getStorefrontWithCompletion:")]
		void GetStorefrontWithCompletion(Action<RCStorefront> completion);

		// @required -(void)getStorefrontWithCompletionHandler:(void (^ _Nonnull)(RCStorefront * _Nullable))completionHandler;
		[Abstract]
		[Export("getStorefrontWithCompletionHandler:")]
		void GetStorefrontWithCompletionHandler(Action<RCStorefront> completionHandler);

		// @required -(void)logIn:(NSString * _Nonnull)appUserID completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, int, NSError * _Nullable))completion;
		[Abstract]
		[Export("logIn:completion:")]
		void LogInWithCompletion(string appUserID, Action<RCCustomerInfo, int, NSError> completion);

		// @required -(void)logIn:(NSString * _Nonnull)appUserID completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("logIn:completionHandler:")]
		void LogInWithCompletionHandler(string appUserID, Action<RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)logOutWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("logOutWithCompletion:")]
		void LogOutWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

		// @required -(void)logOutWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("logOutWithCompletionHandler:")]
		void LogOutWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)getCustomerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("getCustomerInfoWithCompletion:")]
		void GetCustomerInfoWithCompletion(Action<RCCustomerInfo, NSError> completion);

		// @required -(void)getCustomerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("getCustomerInfoWithFetchPolicy:completion:")]
		void GetCustomerInfoWithFetchPolicy(RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completion);

		// @required -(void)customerInfoWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("customerInfoWithCompletionHandler:")]
		void CustomerInfoWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)customerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("customerInfoWithFetchPolicy:completionHandler:")]
		void CustomerInfoWithFetchPolicy(RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCCustomerInfo * _Nullable cachedCustomerInfo;
		[Abstract]
		[NullAllowed, Export("cachedCustomerInfo", ArgumentSemantic.Strong)]
		RCCustomerInfo CachedCustomerInfo { get; }

		// @required -(void)getOfferingsWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("getOfferingsWithCompletion:")]
		void GetOfferingsWithCompletion(Action<RCOfferings, NSError> completion);

		// @required -(void)offeringsWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("offeringsWithCompletionHandler:")]
		void OfferingsWithCompletionHandler(Action<RCOfferings, NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCOfferings * _Nullable cachedOfferings;
		[Abstract]
		[NullAllowed, Export("cachedOfferings", ArgumentSemantic.Strong)]
		RCOfferings CachedOfferings { get; }

		// @required -(void)getProductsWithIdentifiers:(id)productIdentifiers completion:(void (^ _Nonnull)(int))completion;
		[Abstract]
		[Export("getProductsWithIdentifiers:completion:")]
		void GetProductsWithIdentifiers(NSObject productIdentifiers, Action<int> completion);

		// @required -(void)products:(id)productIdentifiers completionHandler:(void (^ _Nonnull)(int))completionHandler;
		[Abstract]
		[Export("products:completionHandler:")]
		void Products(NSObject productIdentifiers, Action<int> completionHandler);

		// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		[Abstract]
		[Export("purchaseProduct:withCompletion:")]
		void PurchaseProduct(RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("purchaseWithProduct:completionHandler:")]
		void PurchaseWithProduct(RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		[Abstract]
		[Export("purchasePackage:withCompletion:")]
		void PurchasePackage(RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("purchaseWithPackage:completionHandler:")]
		void PurchaseWithPackage(RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchaseWithParams:(RCPurchaseParams * _Nonnull)params completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		[Abstract]
		[Export("purchaseWithParams:completion:")]
		void PurchaseWithParams(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchase:(RCPurchaseParams * _Nonnull)params completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("purchase:completionHandler:")]
		void Purchase(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)invalidateCustomerInfoCache;
		[Abstract]
		[Export("invalidateCustomerInfoCache")]
		void InvalidateCustomerInfoCache();

		// @required -(void)restorePurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("restorePurchasesWithCompletion:")]
		void RestorePurchasesWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

		// @required -(void)restorePurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("restorePurchasesWithCompletionHandler:")]
		void RestorePurchasesWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		[Abstract]
		[Export("purchaseProduct:withPromotionalOffer:completion:")]
		void PurchaseProduct(RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("purchaseWithProduct:promotionalOffer:completionHandler:")]
		void PurchaseWithProduct(RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		[Abstract]
		[Export("purchasePackage:withPromotionalOffer:completion:")]
		void PurchasePackage(RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("purchaseWithPackage:promotionalOffer:completionHandler:")]
		void PurchaseWithPackage(RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)checkTrialOrIntroDiscountEligibility:(id)productIdentifiers completion:(void (^ _Nonnull)(int))receiveEligibility;
		[Abstract]
		[Export("checkTrialOrIntroDiscountEligibility:completion:")]
		void CheckTrialOrIntroDiscountEligibility(NSObject productIdentifiers, Action<int> receiveEligibility);

		// @required -(void)checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:(id)productIdentifiers completionHandler:(void (^ _Nonnull)(int))completionHandler;
		[Abstract]
		[Export("checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:completionHandler:")]
		void CheckTrialOrIntroDiscountEligibilityWithProductIdentifiers(NSObject productIdentifiers, Action<int> completionHandler);

		// @required -(void)checkTrialOrIntroDiscountEligibilityForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completion;
		[Abstract]
		[Export("checkTrialOrIntroDiscountEligibilityForProduct:completion:")]
		void CheckTrialOrIntroDiscountEligibilityForProduct(RCStoreProduct product, Action<RCIntroEligibilityStatus> completion);

		// @required -(void)checkTrialOrIntroDiscountEligibilityWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completionHandler;
		[Abstract]
		[Export("checkTrialOrIntroDiscountEligibilityWithProduct:completionHandler:")]
		void CheckTrialOrIntroDiscountEligibilityWithProduct(RCStoreProduct product, Action<RCIntroEligibilityStatus> completionHandler);

		// @required -(void)getPromotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount withProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("getPromotionalOfferForProductDiscount:withProduct:withCompletion:")]
		void GetPromotionalOfferForProductDiscount(RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completion);

		// @required -(void)promotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount product:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completionHandler;
		[Abstract]
		[Export("promotionalOfferForProductDiscount:product:completionHandler:")]
		void PromotionalOfferForProductDiscount(RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completionHandler);

		// @required -(void)eligiblePromotionalOffersForProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(int))completionHandler;
		[Abstract]
		[Export("eligiblePromotionalOffersForProduct:completionHandler:")]
		void EligiblePromotionalOffersForProduct(RCStoreProduct product, Action<int> completionHandler);

		// @required -(void)eligibleWinBackOffersForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(int))completion __attribute__((availability(visionos, introduced=2.0))) __attribute__((availability(watchos, introduced=11.0))) __attribute__((availability(tvos, introduced=18.0))) __attribute__((availability(macos, introduced=15.0))) __attribute__((availability(ios, introduced=18.0)));
		[Abstract]
		[Export("eligibleWinBackOffersForProduct:completion:")]
		void EligibleWinBackOffersForProduct(RCStoreProduct product, Action<int> completion);

		// @required -(void)eligibleWinBackOffersForPackage:(RCPackage * _Nonnull)package completion:(void (^ _Nonnull)(int))completion __attribute__((availability(visionos, introduced=2.0))) __attribute__((availability(watchos, introduced=11.0))) __attribute__((availability(tvos, introduced=18.0))) __attribute__((availability(macos, introduced=15.0))) __attribute__((availability(ios, introduced=18.0)));
		[Abstract]
		[Export("eligibleWinBackOffersForPackage:completion:")]
		void EligibleWinBackOffersForPackage(RCPackage package, Action<int> completion);

		// @required -(void)beginRefundRequestForProduct:(NSString * _Nonnull)productID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		[Abstract]
		[Export("beginRefundRequestForProduct:completion:")]
		void BeginRefundRequestForProduct(string productID, Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)beginRefundRequestForEntitlement:(NSString * _Nonnull)entitlementID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		[Abstract]
		[Export("beginRefundRequestForEntitlement:completion:")]
		void BeginRefundRequestForEntitlement(string entitlementID, Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)beginRefundRequestForActiveEntitlementWithCompletion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		[Abstract]
		[Export("beginRefundRequestForActiveEntitlementWithCompletion:")]
		void BeginRefundRequestForActiveEntitlementWithCompletion(Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
		[Abstract]
		[Export("presentCodeRedemptionSheet")]
		void PresentCodeRedemptionSheet();

		// @required -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
		[Abstract]
		[Export("showPriceConsentIfNeeded")]
		void ShowPriceConsentIfNeeded();

		// @required -(void)showManageSubscriptionsWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		[Abstract]
		[Export("showManageSubscriptionsWithCompletion:")]
		void ShowManageSubscriptionsWithCompletion(Action<NSError> completion);

		// @required -(void)showManageSubscriptionsWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		[Abstract]
		[Export("showManageSubscriptionsWithCompletionHandler:")]
		void ShowManageSubscriptionsWithCompletionHandler(Action<NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCAttribution * _Nonnull attribution;
		[Abstract]
		[Export("attribution", ArgumentSemantic.Strong)]
		RCAttribution Attribution { get; }

		// @required -(void)syncAttributesAndOfferingsIfNeededWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("syncAttributesAndOfferingsIfNeededWithCompletion:")]
		void SyncAttributesAndOfferingsIfNeededWithCompletion(Action<RCOfferings, NSError> completion);

		// @required -(void)syncAttributesAndOfferingsIfNeededWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Abstract]
		[Export("syncAttributesAndOfferingsIfNeededWithCompletionHandler:")]
		void SyncAttributesAndOfferingsIfNeededWithCompletionHandler(Action<RCOfferings, NSError> completionHandler);

		// @required -(void)redeemWebPurchaseWithWebPurchaseRedemption:(RCWebPurchaseRedemption * _Nonnull)webPurchaseRedemption completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export("redeemWebPurchaseWithWebPurchaseRedemption:completion:")]
		void RedeemWebPurchaseWithWebPurchaseRedemption(RCWebPurchaseRedemption webPurchaseRedemption, Action<RCCustomerInfo, NSError> completion);

		// @required -(void)getVirtualCurrenciesWithCompletion:(void (^ _Nonnull)(RCVirtualCurrencies * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("getVirtualCurrenciesWithCompletion:")]
		void GetVirtualCurrenciesWithCompletion (Action<RCVirtualCurrencies, NSError> completion);

		// @required @property (readonly, nonatomic, strong) RCVirtualCurrencies * _Nullable cachedVirtualCurrencies;
		[Abstract]
		[NullAllowed, Export ("cachedVirtualCurrencies", ArgumentSemantic.Strong)]
		RCVirtualCurrencies CachedVirtualCurrencies { get; }

		// @required -(void)invalidateVirtualCurrenciesCache;
		[Abstract]
		[Export ("invalidateVirtualCurrenciesCache")]
		void InvalidateVirtualCurrenciesCache ();
 
		// @required -(void)setAttributes:(id)attributes;
		[Abstract]
		[Export("setAttributes:")]
		void SetAttributes(NSObject attributes);

		// @required @property (nonatomic) int allowSharingAppStoreAccount __attribute__((deprecated("")));
		[Abstract]
		[Export("allowSharingAppStoreAccount")]
		int AllowSharingAppStoreAccount { get; set; }

		// @required -(void)setEmail:(NSString * _Nullable)email __attribute__((deprecated("")));
		[Abstract]
		[Export("setEmail:")]
		void SetEmail([NullAllowed] string email);

		// @required -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber __attribute__((deprecated("")));
		[Abstract]
		[Export("setPhoneNumber:")]
		void SetPhoneNumber([NullAllowed] string phoneNumber);

		// @required -(void)setDisplayName:(NSString * _Nullable)displayName __attribute__((deprecated("")));
		[Abstract]
		[Export("setDisplayName:")]
		void SetDisplayName([NullAllowed] string displayName);

		// @required -(void)setPushToken:(NSData * _Nullable)pushToken __attribute__((deprecated("")));
		[Abstract]
		[Export("setPushToken:")]
		void SetPushToken([NullAllowed] NSData pushToken);

		// @required -(void)setPushTokenString:(NSString * _Nullable)pushToken __attribute__((deprecated("")));
		[Abstract]
		[Export("setPushTokenString:")]
		void SetPushTokenString([NullAllowed] string pushToken);

		// @required -(void)setAdjustID:(NSString * _Nullable)adjustID __attribute__((deprecated("")));
		[Abstract]
		[Export("setAdjustID:")]
		void SetAdjustID([NullAllowed] string adjustID);

		// @required -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID __attribute__((deprecated("")));
		[Abstract]
		[Export("setAppsflyerID:")]
		void SetAppsflyerID([NullAllowed] string appsflyerID);

		// @required -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID __attribute__((deprecated("")));
		[Abstract]
		[Export("setFBAnonymousID:")]
		void SetFBAnonymousID([NullAllowed] string fbAnonymousID);

		// @required -(void)setMparticleID:(NSString * _Nullable)mparticleID __attribute__((deprecated("")));
		[Abstract]
		[Export("setMparticleID:")]
		void SetMparticleID([NullAllowed] string mparticleID);

		// @required -(void)setOnesignalID:(NSString * _Nullable)onesignalID __attribute__((deprecated("")));
		[Abstract]
		[Export("setOnesignalID:")]
		void SetOnesignalID([NullAllowed] string onesignalID);

		// @required -(void)setMediaSource:(NSString * _Nullable)mediaSource __attribute__((deprecated("")));
		[Abstract]
		[Export("setMediaSource:")]
		void SetMediaSource([NullAllowed] string mediaSource);

		// @required -(void)setCampaign:(NSString * _Nullable)campaign __attribute__((deprecated("")));
		[Abstract]
		[Export("setCampaign:")]
		void SetCampaign([NullAllowed] string campaign);

		// @required -(void)setAdGroup:(NSString * _Nullable)adGroup __attribute__((deprecated("")));
		[Abstract]
		[Export("setAdGroup:")]
		void SetAdGroup([NullAllowed] string adGroup);

		// @required -(void)setAd:(NSString * _Nullable)value __attribute__((deprecated("")));
		[Abstract]
		[Export("setAd:")]
		void SetAd([NullAllowed] string value);

		// @required -(void)setKeyword:(NSString * _Nullable)keyword __attribute__((deprecated("")));
		[Abstract]
		[Export("setKeyword:")]
		void SetKeyword([NullAllowed] string keyword);

		// @required -(void)setCreative:(NSString * _Nullable)creative __attribute__((deprecated("")));
		[Abstract]
		[Export("setCreative:")]
		void SetCreative([NullAllowed] string creative);

		// @required -(void)setCleverTapID:(NSString * _Nullable)cleverTapID __attribute__((deprecated("")));
		[Abstract]
		[Export("setCleverTapID:")]
		void SetCleverTapID([NullAllowed] string cleverTapID);

		// @required -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID __attribute__((deprecated("")));
		[Abstract]
		[Export("setMixpanelDistinctID:")]
		void SetMixpanelDistinctID([NullAllowed] string mixpanelDistinctID);

		// @required -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID __attribute__((deprecated("")));
		[Abstract]
		[Export("setFirebaseAppInstanceID:")]
		void SetFirebaseAppInstanceID([NullAllowed] string firebaseAppInstanceID);

		// @required -(void)collectDeviceIdentifiers __attribute__((deprecated("")));
		[Abstract]
		[Export("collectDeviceIdentifiers")]
		void CollectDeviceIdentifiers();

		// @required -(void)params:(RCPurchaseParams * _Nonnull)params withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion __attribute__((deprecated("")));
		[Abstract]
		[Export("params:withCompletion:")]
		void Params(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required @property (nonatomic) int finishTransactions __attribute__((deprecated("Use purchasesAreCompletedBy instead.")));
		[Abstract]
		[Export("finishTransactions")]
		int FinishTransactions { get; set; }
	}

// @interface RCPurchases <RCPurchasesType>
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPurchases
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull appUserID;
		 [Export("appUserID")] string AppUserID { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nullable storeFrontCountryCode;
		
		[NullAllowed, Export("storeFrontCountryCode")]
		string StoreFrontCountryCode { get; }

		// @required @property (readonly, nonatomic) int isAnonymous;
		 [Export("isAnonymous")] int IsAnonymous { get; }

		// @required @property (nonatomic) enum RCPurchasesAreCompletedBy purchasesAreCompletedBy;
		
		[Export("purchasesAreCompletedBy", ArgumentSemantic.Assign)]
		RCPurchasesAreCompletedBy PurchasesAreCompletedBy { get; set; }

		[Wrap("WeakDelegate"), Abstract]
		[NullAllowed]
		RCPurchasesDelegate Delegate { get; set; }

		// @required @property (nonatomic, strong) id<RCPurchasesDelegate> _Nullable delegate;
		
		[NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @required -(void)getStorefrontWithCompletion:(void (^ _Nonnull)(RCStorefront * _Nullable))completion;
		
		[Export("getStorefrontWithCompletion:")]
		void GetStorefrontWithCompletion(Action<RCStorefront> completion);

		// @required -(void)getStorefrontWithCompletionHandler:(void (^ _Nonnull)(RCStorefront * _Nullable))completionHandler;
		
		[Export("getStorefrontWithCompletionHandler:")]
		void GetStorefrontWithCompletionHandler(Action<RCStorefront> completionHandler);

		// @required -(void)logIn:(NSString * _Nonnull)appUserID completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, int, NSError * _Nullable))completion;
		
		[Export("logIn:completion:")]
		void LogInWithCompletion(string appUserID, Action<RCCustomerInfo, int, NSError> completion);

		// @required -(void)logIn:(NSString * _Nonnull)appUserID completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("logIn:completionHandler:")]
		void LogInWithCompletionHandler(string appUserID, Action<RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)logOutWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		
		[Export("logOutWithCompletion:")]
		void LogOutWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

		// @required -(void)logOutWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("logOutWithCompletionHandler:")]
		void LogOutWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)getCustomerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		
		[Export("getCustomerInfoWithCompletion:")]
		void GetCustomerInfoWithCompletion(Action<RCCustomerInfo, NSError> completion);

		// @required -(void)getCustomerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		
		[Export("getCustomerInfoWithFetchPolicy:completion:")]
		void GetCustomerInfoWithFetchPolicy(RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completion);

		// @required -(void)customerInfoWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("customerInfoWithCompletionHandler:")]
		void CustomerInfoWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)customerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("customerInfoWithFetchPolicy:completionHandler:")]
		void CustomerInfoWithFetchPolicy(RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCCustomerInfo * _Nullable cachedCustomerInfo;
		
		[NullAllowed, Export("cachedCustomerInfo", ArgumentSemantic.Strong)]
		RCCustomerInfo CachedCustomerInfo { get; }

		// @required -(void)getOfferingsWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
		
		[Export("getOfferingsWithCompletion:")]
		void GetOfferingsWithCompletion(Action<RCOfferings, NSError> completion);

		// @required -(void)offeringsWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("offeringsWithCompletionHandler:")]
		void OfferingsWithCompletionHandler(Action<RCOfferings, NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCOfferings * _Nullable cachedOfferings;
		
		[NullAllowed, Export("cachedOfferings", ArgumentSemantic.Strong)]
		RCOfferings CachedOfferings { get; }

		// @required -(void)getProductsWithIdentifiers:(id)productIdentifiers completion:(void (^ _Nonnull)(int))completion;
		
		[Export("getProductsWithIdentifiers:completion:")]
		void GetProductsWithIdentifiers(NSObject productIdentifiers, Action<int> completion);

		// @required -(void)products:(id)productIdentifiers completionHandler:(void (^ _Nonnull)(int))completionHandler;
		
		[Export("products:completionHandler:")]
		void Products(NSObject productIdentifiers, Action<int> completionHandler);

		// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		
		[Export("purchaseProduct:withCompletion:")]
		void PurchaseProduct(RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("purchaseWithProduct:completionHandler:")]
		void PurchaseWithProduct(RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		
		[Export("purchasePackage:withCompletion:")]
		void PurchasePackage(RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("purchaseWithPackage:completionHandler:")]
		void PurchaseWithPackage(RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchaseWithParams:(RCPurchaseParams * _Nonnull)params completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		
		[Export("purchaseWithParams:completion:")]
		void PurchaseWithParams(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchase:(RCPurchaseParams * _Nonnull)params completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("purchase:completionHandler:")]
		void Purchase(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)invalidateCustomerInfoCache;
		
		[Export("invalidateCustomerInfoCache")]
		void InvalidateCustomerInfoCache();

		// @required -(void)restorePurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		
		[Export("restorePurchasesWithCompletion:")]
		void RestorePurchasesWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

		// @required -(void)restorePurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("restorePurchasesWithCompletionHandler:")]
		void RestorePurchasesWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);

		// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		
		[Export("purchaseProduct:withPromotionalOffer:completion:")]
		void PurchaseProduct(RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("purchaseWithProduct:promotionalOffer:completionHandler:")]
		void PurchaseWithProduct(RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion;
		
		[Export("purchasePackage:withPromotionalOffer:completion:")]
		void PurchasePackage(RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, int, NSError * _Nullable))completionHandler;
		
		[Export("purchaseWithPackage:promotionalOffer:completionHandler:")]
		void PurchaseWithPackage(RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, int, NSError> completionHandler);

		// @required -(void)checkTrialOrIntroDiscountEligibility:(id)productIdentifiers completion:(void (^ _Nonnull)(int))receiveEligibility;
		
		[Export("checkTrialOrIntroDiscountEligibility:completion:")]
		void CheckTrialOrIntroDiscountEligibility(NSObject productIdentifiers, Action<int> receiveEligibility);

		// @required -(void)checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:(id)productIdentifiers completionHandler:(void (^ _Nonnull)(int))completionHandler;
		
		[Export("checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:completionHandler:")]
		void CheckTrialOrIntroDiscountEligibilityWithProductIdentifiers(NSObject productIdentifiers, Action<int> completionHandler);

		// @required -(void)checkTrialOrIntroDiscountEligibilityForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completion;
		
		[Export("checkTrialOrIntroDiscountEligibilityForProduct:completion:")]
		void CheckTrialOrIntroDiscountEligibilityForProduct(RCStoreProduct product, Action<RCIntroEligibilityStatus> completion);

		// @required -(void)checkTrialOrIntroDiscountEligibilityWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completionHandler;
		
		[Export("checkTrialOrIntroDiscountEligibilityWithProduct:completionHandler:")]
		void CheckTrialOrIntroDiscountEligibilityWithProduct(RCStoreProduct product, Action<RCIntroEligibilityStatus> completionHandler);

		// @required -(void)getPromotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount withProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completion;
		
		[Export("getPromotionalOfferForProductDiscount:withProduct:withCompletion:")]
		void GetPromotionalOfferForProductDiscount(RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completion);

		// @required -(void)promotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount product:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("promotionalOfferForProductDiscount:product:completionHandler:")]
		void PromotionalOfferForProductDiscount(RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completionHandler);

		// @required -(void)eligiblePromotionalOffersForProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(int))completionHandler;
		
		[Export("eligiblePromotionalOffersForProduct:completionHandler:")]
		void EligiblePromotionalOffersForProduct(RCStoreProduct product, Action<int> completionHandler);

		// @required -(void)eligibleWinBackOffersForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(int))completion __attribute__((availability(visionos, introduced=2.0))) __attribute__((availability(watchos, introduced=11.0))) __attribute__((availability(tvos, introduced=18.0))) __attribute__((availability(macos, introduced=15.0))) __attribute__((availability(ios, introduced=18.0)));
		
		[Export("eligibleWinBackOffersForProduct:completion:")]
		void EligibleWinBackOffersForProduct(RCStoreProduct product, Action<int> completion);

		// @required -(void)eligibleWinBackOffersForPackage:(RCPackage * _Nonnull)package completion:(void (^ _Nonnull)(int))completion __attribute__((availability(visionos, introduced=2.0))) __attribute__((availability(watchos, introduced=11.0))) __attribute__((availability(tvos, introduced=18.0))) __attribute__((availability(macos, introduced=15.0))) __attribute__((availability(ios, introduced=18.0)));
		
		[Export("eligibleWinBackOffersForPackage:completion:")]
		void EligibleWinBackOffersForPackage(RCPackage package, Action<int> completion);

		// @required -(void)beginRefundRequestForProduct:(NSString * _Nonnull)productID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		
		[Export("beginRefundRequestForProduct:completion:")]
		void BeginRefundRequestForProduct(string productID, Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)beginRefundRequestForEntitlement:(NSString * _Nonnull)entitlementID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		
		[Export("beginRefundRequestForEntitlement:completion:")]
		void BeginRefundRequestForEntitlement(string entitlementID, Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)beginRefundRequestForActiveEntitlementWithCompletion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
		
		[Export("beginRefundRequestForActiveEntitlementWithCompletion:")]
		void BeginRefundRequestForActiveEntitlementWithCompletion(Action<RCRefundRequestStatus, NSError> completionHandler);

		// @required -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
		
		[Export("presentCodeRedemptionSheet")]
		void PresentCodeRedemptionSheet();

		// @required -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
		
		[Export("showPriceConsentIfNeeded")]
		void ShowPriceConsentIfNeeded();

		// @required -(void)showManageSubscriptionsWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		
		[Export("showManageSubscriptionsWithCompletion:")]
		void ShowManageSubscriptionsWithCompletion(Action<NSError> completion);

		// @required -(void)showManageSubscriptionsWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		
		[Export("showManageSubscriptionsWithCompletionHandler:")]
		void ShowManageSubscriptionsWithCompletionHandler(Action<NSError> completionHandler);

		// @required @property (readonly, nonatomic, strong) RCAttribution * _Nonnull attribution;
		
		[Export("attribution", ArgumentSemantic.Strong)]
		RCAttribution Attribution { get; }

		// @required -(void)syncAttributesAndOfferingsIfNeededWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
		
		[Export("syncAttributesAndOfferingsIfNeededWithCompletion:")]
		void SyncAttributesAndOfferingsIfNeededWithCompletion(Action<RCOfferings, NSError> completion);

		// @required -(void)syncAttributesAndOfferingsIfNeededWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		
		[Export("syncAttributesAndOfferingsIfNeededWithCompletionHandler:")]
		void SyncAttributesAndOfferingsIfNeededWithCompletionHandler(Action<RCOfferings, NSError> completionHandler);

		// @required -(void)redeemWebPurchaseWithWebPurchaseRedemption:(RCWebPurchaseRedemption * _Nonnull)webPurchaseRedemption completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		
		[Export("redeemWebPurchaseWithWebPurchaseRedemption:completion:")]
		void RedeemWebPurchaseWithWebPurchaseRedemption(RCWebPurchaseRedemption webPurchaseRedemption, Action<RCCustomerInfo, NSError> completion);

		// @required -(void)getVirtualCurrenciesWithCompletion:(void (^ _Nonnull)(RCVirtualCurrencies * _Nullable, NSError * _Nullable))completion;
		
		[Export ("getVirtualCurrenciesWithCompletion:")]
		void GetVirtualCurrenciesWithCompletion (Action<RCVirtualCurrencies, NSError> completion);

		// @required @property (readonly, nonatomic, strong) RCVirtualCurrencies * _Nullable cachedVirtualCurrencies;
		
		[NullAllowed, Export ("cachedVirtualCurrencies", ArgumentSemantic.Strong)]
		RCVirtualCurrencies CachedVirtualCurrencies { get; }

		// @required -(void)invalidateVirtualCurrenciesCache;
		
		[Export ("invalidateVirtualCurrenciesCache")]
		void InvalidateVirtualCurrenciesCache ();
 
		// @required -(void)setAttributes:(id)attributes;
		
		[Export("setAttributes:")]
		void SetAttributes(NSObject attributes);

		// @required @property (nonatomic) int allowSharingAppStoreAccount __attribute__((deprecated("")));
		
		[Export("allowSharingAppStoreAccount")]
		int AllowSharingAppStoreAccount { get; set; }

		// @required -(void)setEmail:(NSString * _Nullable)email __attribute__((deprecated("")));
		
		[Export("setEmail:")]
		void SetEmail([NullAllowed] string email);

		// @required -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber __attribute__((deprecated("")));
		
		[Export("setPhoneNumber:")]
		void SetPhoneNumber([NullAllowed] string phoneNumber);

		// @required -(void)setDisplayName:(NSString * _Nullable)displayName __attribute__((deprecated("")));
		
		[Export("setDisplayName:")]
		void SetDisplayName([NullAllowed] string displayName);

		// @required -(void)setPushToken:(NSData * _Nullable)pushToken __attribute__((deprecated("")));
		
		[Export("setPushToken:")]
		void SetPushToken([NullAllowed] NSData pushToken);

		// @required -(void)setPushTokenString:(NSString * _Nullable)pushToken __attribute__((deprecated("")));
		
		[Export("setPushTokenString:")]
		void SetPushTokenString([NullAllowed] string pushToken);

		// @required -(void)setAdjustID:(NSString * _Nullable)adjustID __attribute__((deprecated("")));
		
		[Export("setAdjustID:")]
		void SetAdjustID([NullAllowed] string adjustID);

		// @required -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID __attribute__((deprecated("")));
		
		[Export("setAppsflyerID:")]
		void SetAppsflyerID([NullAllowed] string appsflyerID);

		// @required -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID __attribute__((deprecated("")));
		
		[Export("setFBAnonymousID:")]
		void SetFBAnonymousID([NullAllowed] string fbAnonymousID);

		// @required -(void)setMparticleID:(NSString * _Nullable)mparticleID __attribute__((deprecated("")));
		
		[Export("setMparticleID:")]
		void SetMparticleID([NullAllowed] string mparticleID);

		// @required -(void)setOnesignalID:(NSString * _Nullable)onesignalID __attribute__((deprecated("")));
		
		[Export("setOnesignalID:")]
		void SetOnesignalID([NullAllowed] string onesignalID);

		// @required -(void)setMediaSource:(NSString * _Nullable)mediaSource __attribute__((deprecated("")));
		
		[Export("setMediaSource:")]
		void SetMediaSource([NullAllowed] string mediaSource);

		// @required -(void)setCampaign:(NSString * _Nullable)campaign __attribute__((deprecated("")));
		
		[Export("setCampaign:")]
		void SetCampaign([NullAllowed] string campaign);

		// @required -(void)setAdGroup:(NSString * _Nullable)adGroup __attribute__((deprecated("")));
		
		[Export("setAdGroup:")]
		void SetAdGroup([NullAllowed] string adGroup);

		// @required -(void)setAd:(NSString * _Nullable)value __attribute__((deprecated("")));
		
		[Export("setAd:")]
		void SetAd([NullAllowed] string value);

		// @required -(void)setKeyword:(NSString * _Nullable)keyword __attribute__((deprecated("")));
		
		[Export("setKeyword:")]
		void SetKeyword([NullAllowed] string keyword);

		// @required -(void)setCreative:(NSString * _Nullable)creative __attribute__((deprecated("")));
		
		[Export("setCreative:")]
		void SetCreative([NullAllowed] string creative);

		// @required -(void)setCleverTapID:(NSString * _Nullable)cleverTapID __attribute__((deprecated("")));
		
		[Export("setCleverTapID:")]
		void SetCleverTapID([NullAllowed] string cleverTapID);

		// @required -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID __attribute__((deprecated("")));
		
		[Export("setMixpanelDistinctID:")]
		void SetMixpanelDistinctID([NullAllowed] string mixpanelDistinctID);

		// @required -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID __attribute__((deprecated("")));
		
		[Export("setFirebaseAppInstanceID:")]
		void SetFirebaseAppInstanceID([NullAllowed] string firebaseAppInstanceID);

		// @required -(void)collectDeviceIdentifiers __attribute__((deprecated("")));
		
		[Export("collectDeviceIdentifiers")]
		void CollectDeviceIdentifiers();

		// @required -(void)params:(RCPurchaseParams * _Nonnull)params withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int))completion __attribute__((deprecated("")));
		
		[Export("params:withCompletion:")]
		void Params(RCPurchaseParams @params, Action<RCStoreTransaction, RCCustomerInfo, NSError, int> completion);

		// @required @property (nonatomic) int finishTransactions __attribute__((deprecated("Use purchasesAreCompletedBy instead.")));
		
		[Export("finishTransactions")]
		int FinishTransactions { get; set; }
		  
		// @property (readonly, nonatomic) int isSandbox;
		[Export("isSandbox")] int IsSandbox { get; }
		

		// -(void)syncPurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
		[Export("syncPurchasesWithCompletion:")]
		void SyncPurchasesWithCompletion([NullAllowed] Action<RCCustomerInfo, NSError> completion);

		// -(void)syncPurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler;
		
		[Export("syncPurchasesWithCompletionHandler:")]
		void SyncPurchasesWithCompletionHandler(Action<RCCustomerInfo, NSError> completionHandler);
		
		// +(RCPurchases * _Nonnull)configureWithConfiguration:(RCConfiguration * _Nonnull)configuration;
		[Static]
		[Export("configureWithConfiguration:")]
		RCPurchases ConfigureWithConfiguration(RCConfiguration configuration);

		// +(RCPurchases * _Nonnull)configureWithConfigurationBuilder:(RCConfigurationBuilder * _Nonnull)builder;
		[Static]
		[Export("configureWithConfigurationBuilder:")]
		RCPurchases ConfigureWithConfigurationBuilder(RCConfigurationBuilder builder);

		// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey;
		[Static]
		[Export("configureWithAPIKey:")]
		RCPurchases ConfigureWithAPIKey(string apiKey);

		// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID;
		[Static]
		[Export("configureWithAPIKey:appUserID:")]
		RCPurchases ConfigureWithAPIKey(string apiKey, [NullAllowed] string appUserID);

		// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID purchasesAreCompletedBy:(enum RCPurchasesAreCompletedBy)purchasesAreCompletedBy storeKitVersion:(enum RCStoreKitVersion)storeKitVersion;
		[Static]
		[Export("configureWithAPIKey:appUserID:purchasesAreCompletedBy:storeKitVersion:")]
		RCPurchases ConfigureWithAPIKey(string apiKey, [NullAllowed] string appUserID, RCPurchasesAreCompletedBy purchasesAreCompletedBy, RCStoreKitVersion storeKitVersion);
		
		// @property (nonatomic, class) int debugLogsEnabled __attribute__((deprecated("use Purchases.logLevel instead")));
		[Static] [Export("debugLogsEnabled")] int DebugLogsEnabled { get; set; }
		
		// +(void)addAttributionData:(id)data fromNetwork:(enum RCAttributionNetwork)network __attribute__((deprecated("Use the set<NetworkId> functions instead")));
		[Static]
		[Export("addAttributionData:fromNetwork:")]
		void AddAttributionData(NSObject data, RCAttributionNetwork network);

		// +(void)addAttributionData:(id)data fromNetwork:(enum RCAttributionNetwork)network forNetworkUserId:(NSString * _Nullable)networkUserId __attribute__((deprecated("Use the set<NetworkId> functions instead")));
		[Static]
		[Export("addAttributionData:fromNetwork:forNetworkUserId:")]
		void AddAttributionData(NSObject data, RCAttributionNetwork network, [NullAllowed] string networkUserId);
		
		// @property (readonly, nonatomic, strong, class) RCPurchases * _Nonnull sharedPurchases;
		[Static]
		[Export("sharedPurchases", ArgumentSemantic.Strong)]
		RCPurchases SharedPurchases { get; }

		// @property (readonly, nonatomic, class) int isConfigured;
		[Static] [Export("isConfigured")] int IsConfigured { get; }
		
		// @property (nonatomic, class) enum RCLogLevel logLevel;
		[Static]
		[Export("logLevel", ArgumentSemantic.Assign)]
		RCLogLevel LogLevel { get; set; }

		// @property (copy, nonatomic, class) NSURL * _Nullable proxyURL;
		[Static]
		[NullAllowed, Export("proxyURL", ArgumentSemantic.Copy)]
		NSUrl ProxyURL { get; set; }

		// @property (nonatomic, class) int forceUniversalAppStore;
		[Static]
		[Export("forceUniversalAppStore")]
		int ForceUniversalAppStore { get; set; }

		// @property (nonatomic, class) int simulatesAskToBuyInSandbox __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=8.0)));
		[Static]
		[Export("simulatesAskToBuyInSandbox")]
		int SimulatesAskToBuyInSandbox { get; set; }

		// +(id)canMakePayments __attribute__((warn_unused_result("")));
		[Static]
		[Export("canMakePayments")]
		bool CanMakePayments { get; }

		// @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull) logHandler;
		[Static]
		[Export("logHandler", ArgumentSemantic.Copy)]
		Action<RCLogLevel, NSString> LogHandler { get; set; }

		// @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull, NSString * _Nullable, NSString * _Nullable, int) verboseLogHandler;
		[Static]
		[Export("verboseLogHandler", ArgumentSemantic.Copy)]
		Action<RCLogLevel, NSString, NSString, NSString, int> VerboseLogHandler { get; set; }

		// @property (nonatomic, class) int verboseLogs;
		[Static] [Export("verboseLogs")] int VerboseLogs { get; set; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull frameworkVersion;
		[Static] [Export("frameworkVersion")] string FrameworkVersion { get; }
		
		// @property (nonatomic, strong, class) RCPlatformInfo * _Nullable platformInfo;
		[Static]
		[NullAllowed, Export("platformInfo", ArgumentSemantic.Strong)]
		RCPlatformInfo PlatformInfo { get; set; }
	}

// @interface RCPlatformInfo
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPlatformInfo
	{
		// -(instancetype _Nonnull)initWithFlavor:(NSString * _Nonnull)flavor version:(NSString * _Nonnull)version __attribute__((objc_designated_initializer));
		[Export("initWithFlavor:version:")]
		[DesignatedInitializer]
		NativeHandle Constructor(string flavor, string version);
	}
	
	delegate void PurchaseCallback(RCStoreTransaction transaction, RCCustomerInfo customerInfo, NSError error, int something);
	delegate void StartPurchaseCallback(PurchaseCallback callback);

// @protocol RCPurchasesDelegate
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RCPurchasesDelegate
	{
		// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases receivedUpdatedCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
		[Export("purchases:receivedUpdatedCustomerInfo:")]
		void ReceivedUpdatedCustomerInfo(RCPurchases purchases, RCCustomerInfo customerInfo);

		// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, int)))startPurchase;
		[Export("purchases:readyForPromotedProduct:purchase:")]
		void ReadyForPromotedProduct(RCPurchases purchases, RCStoreProduct product, StartPurchaseCallback startPurchase);

		// @optional @property (readonly, nonatomic) int shouldShowPriceConsent __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
		[Export("shouldShowPriceConsent")]
		int ShouldShowPriceConsent { get; }
	}

// @interface RCPurchasesDiagnostics
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCPurchasesDiagnostics
	{
		// @property (readonly, getter = default, nonatomic, strong, class) RCPurchasesDiagnostics * _Nonnull default_;
		[Static]
		[Export("default_", ArgumentSemantic.Strong)]
		RCPurchasesDiagnostics Default_ { [Bind("default")] get; }
		
		[Export("testSDKHealthWithCompletion:")]
		void TestSDKHealthWithCompletion(Action<NSError> completionHandler);
	}
	

// @interface PurchasesReceiptParser
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject), Name = "_TtC10RevenueCat22PurchasesReceiptParser")]
	interface PurchasesReceiptParser
	{
		// @property (readonly, getter = default, nonatomic, strong, class) PurchasesReceiptParser * _Nonnull default_;
		[Static]
		[Export("default_", ArgumentSemantic.Strong)]
		PurchasesReceiptParser Default_ { [Bind("default")] get; }
	}
	


// @interface RCStoreProduct
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RCStoreProduct 
	{
				// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
		[Export("price", ArgumentSemantic.Strong)]
		NSDecimalNumber Price { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerDay __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerDay", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerDay { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerWeek __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerWeek", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerWeek { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerMonth __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
	
		[Export("pricePerMonth", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerMonth { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerYear __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerYear", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
		[NullAllowed, Export("localizedIntroductoryPriceString")]
		string LocalizedIntroductoryPriceString { get; }

		// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * localizedPricePerDay __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("localizedPricePerDay")]
		string LocalizedPricePerDay { get; }

		// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * localizedPricePerWeek __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("localizedPricePerWeek")]
		string LocalizedPricePerWeek { get; }

		// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * localizedPricePerMonth __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("localizedPricePerMonth")]
		string LocalizedPricePerMonth { get; }

		// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * localizedPricePerYear __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("localizedPricePerYear")]
		string LocalizedPricePerYear { get; }
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }

		// @property (readonly, nonatomic) enum RCStoreProductType productType;
		[Export("productType")] RCStoreProductType ProductType { get; }

		// @property (readonly, nonatomic) enum RCStoreProductCategory productCategory;
		[Export("productCategory")] RCStoreProductCategory ProductCategory { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
		[Export("localizedDescription")] string LocalizedDescription { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedTitle;
		[Export("localizedTitle")] string LocalizedTitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export("currencyCode")] string CurrencyCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
		[Export("localizedPriceString")] string LocalizedPriceString { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
		[Export("productIdentifier")] string ProductIdentifier { get; }

		// @property (readonly, nonatomic) int isFamilyShareable __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
		[Export("isFamilyShareable")]
		int IsFamilyShareable { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subscriptionGroupIdentifier;
		[NullAllowed, Export("subscriptionGroupIdentifier")]
		string SubscriptionGroupIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSNumberFormatter * _Nullable priceFormatter;
		[NullAllowed, Export("priceFormatter", ArgumentSemantic.Strong)]
		NSNumberFormatter PriceFormatter { get; }

		// @property (readonly, nonatomic, strong) RCSubscriptionPeriod * _Nullable subscriptionPeriod;
		[NullAllowed, Export("subscriptionPeriod", ArgumentSemantic.Strong)]
		RCSubscriptionPeriod SubscriptionPeriod { get; }

		// @property (readonly, nonatomic, strong) RCStoreProductDiscount * _Nullable introductoryDiscount;
		[NullAllowed, Export("introductoryDiscount", ArgumentSemantic.Strong)]
		RCStoreProductDiscount IntroductoryDiscount { get; }
		
		// -(instancetype _Nonnull)initWithSk1Product:(SKProduct * _Nonnull)sk1Product;
		[Export("initWithSk1Product:")]
		NativeHandle Constructor(SKProduct sk1Product);

		// @property (readonly, nonatomic, strong) SKProduct * _Nullable sk1Product;
		[NullAllowed, Export("sk1Product", ArgumentSemantic.Strong)]
		SKProduct Sk1Product { get; }
	}
	

// @interface RCStoreProductDiscount
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCStoreProductDiscount
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable offerIdentifier;
		[NullAllowed, Export("offerIdentifier")]
		string OfferIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
		[NullAllowed, Export("currencyCode")] string CurrencyCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
		[Export("localizedPriceString")] string LocalizedPriceString { get; }

		// @property (readonly, nonatomic) enum RCPaymentMode paymentMode;
		[Export("paymentMode")] RCPaymentMode PaymentMode { get; }

		// @property (readonly, nonatomic, strong) RCSubscriptionPeriod * _Nonnull subscriptionPeriod;
		[Export("subscriptionPeriod", ArgumentSemantic.Strong)]
		RCSubscriptionPeriod SubscriptionPeriod { get; }

		// @property (readonly, nonatomic) int numberOfPeriods;
		[Export("numberOfPeriods")] int NumberOfPeriods { get; }

		// @property (readonly, nonatomic) enum RCDiscountType type;
		[Export("type")] RCDiscountType Type { get; }
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }

				
		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
		[Export("price", ArgumentSemantic.Strong)]
		NSDecimalNumber Price { get; }
		
		// @property (readonly, nonatomic, strong) SKProductDiscount * _Nullable sk1Discount;
		[NullAllowed, Export("sk1Discount", ArgumentSemantic.Strong)]
		SKProductDiscount Sk1Discount { get; }
		
		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerDay __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerDay", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerDay { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerWeek __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerWeek", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerWeek { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerMonth __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerMonth", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerMonth { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerYear __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
		[Export("pricePerYear", ArgumentSemantic.Strong)]
		NSDecimalNumber PricePerYear { get; }
	}


// @interface RCStoreTransaction
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCStoreTransaction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
		[Export("productIdentifier")] string ProductIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
		[Export("purchaseDate", ArgumentSemantic.Copy)]
		NSDate PurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
		[Export("transactionIdentifier")] string TransactionIdentifier { get; }

		// @property (readonly, nonatomic) int quantity;
		[Export("quantity")] int Quantity { get; }

		// @property (readonly, nonatomic, strong) RCStorefront * _Nullable storefront;
		[NullAllowed, Export("storefront", ArgumentSemantic.Strong)]
		RCStorefront Storefront { get; }
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
		
		
		// @property (readonly, nonatomic, strong) SKPaymentTransaction * _Nullable sk1Transaction;
		[NullAllowed, Export("sk1Transaction", ArgumentSemantic.Strong)]
		SKPaymentTransaction Sk1Transaction { get; }
	} 

// @interface RCStorefront
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface RCStorefront
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull countryCode;
		[Export("countryCode")] string CountryCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")] string Identifier { get; }
		

		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
		
		// @property (readonly, nonatomic, strong, class) RCStorefront * _Nullable sk1CurrentStorefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Static]
		[NullAllowed, Export("sk1CurrentStorefront", ArgumentSemantic.Strong)]
		RCStorefront Sk1CurrentStorefront { get; }
		
		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(maccatalyst,introduced=13.1) SKStorefront * sk1Storefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Export("sk1Storefront", ArgumentSemantic.Strong)]
		SKStorefront Sk1Storefront { get; }
	}
 
// @interface RCSubscriptionInfo
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCSubscriptionInfo
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
		[Export("productIdentifier")] string ProductIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
		[Export("purchaseDate", ArgumentSemantic.Copy)]
		NSDate PurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
		[NullAllowed, Export("originalPurchaseDate", ArgumentSemantic.Copy)]
		NSDate OriginalPurchaseDate { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable expiresDate;
		[NullAllowed, Export("expiresDate", ArgumentSemantic.Copy)]
		NSDate ExpiresDate { get; }

		// @property (readonly, nonatomic) enum RCStore store;
		[Export("store")] RCStore Store { get; }

		// @property (readonly, nonatomic) int isSandbox;
		[Export("isSandbox")] int IsSandbox { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable unsubscribeDetectedAt;
		[NullAllowed, Export("unsubscribeDetectedAt", ArgumentSemantic.Copy)]
		NSDate UnsubscribeDetectedAt { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable billingIssuesDetectedAt;
		[NullAllowed, Export("billingIssuesDetectedAt", ArgumentSemantic.Copy)]
		NSDate BillingIssuesDetectedAt { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable gracePeriodExpiresDate;
		[NullAllowed, Export("gracePeriodExpiresDate", ArgumentSemantic.Copy)]
		NSDate GracePeriodExpiresDate { get; }

		// @property (readonly, nonatomic) enum RCPurchaseOwnershipType ownershipType;
		[Export("ownershipType")] RCPurchaseOwnershipType OwnershipType { get; }

		// @property (readonly, nonatomic) enum RCPeriodType periodType;
		[Export("periodType")] RCPeriodType PeriodType { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable refundedAt;
		[NullAllowed, Export("refundedAt", ArgumentSemantic.Copy)]
		NSDate RefundedAt { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable storeTransactionId;
		[NullAllowed, Export("storeTransactionId")]
		string StoreTransactionId { get; }

		// @property (readonly, nonatomic) int isActive;
		[Export("isActive")] int IsActive { get; }

		// @property (readonly, nonatomic) int willRenew;
		[Export("willRenew")] int WillRenew { get; }
		
		// @property (readonly, copy, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable managementURL;
		[NullAllowed, Export ("managementURL", ArgumentSemantic.Copy)]
		NSUrl ManagementURL { get; }

		// @property (readonly, nonatomic, strong) RCProductPaidPrice * _Nullable price;
		[NullAllowed, Export("price", ArgumentSemantic.Strong)]
		RCProductPaidPrice Price { get; } 
		
	}

// @interface RCSubscriptionPeriod
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCSubscriptionPeriod
	{
		// @property (readonly, nonatomic) int value;
		[Export("value")] int Value { get; }

		// @property (readonly, nonatomic) enum RCSubscriptionPeriodUnit unit;
		[Export("unit")] RCSubscriptionPeriodUnit Unit { get; }

		
		// @property (readonly, nonatomic) int hash;
		[Export("hash")] int Hash { get; }
		
	}


// @interface RCWebPurchaseRedemption
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCWebPurchaseRedemption
	{
	}

// @interface RCWinBackOffer
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCWinBackOffer
	{
		// @property (readonly, nonatomic, strong) RCStoreProductDiscount * _Nonnull discount;
		[Export("discount", ArgumentSemantic.Strong)]
		RCStoreProductDiscount Discount { get; }
	}


// @interface RCVirtualCurrencies
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCVirtualCurrencies
	{
		// -(RCVirtualCurrency * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("objectForKeyedSubscript:")]
		[return: NullAllowed]
		RCVirtualCurrency ObjectForKeyedSubscript (string key);
	}

// @interface RCVirtualCurrency
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface RCVirtualCurrency
	{
		// @property (readonly, nonatomic) int balance;
		[Export ("balance")]
		int Balance { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull code;
		[Export ("code")]
		string Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable serverDescription;
		[NullAllowed, Export ("serverDescription")]
		string ServerDescription { get; }
	}

