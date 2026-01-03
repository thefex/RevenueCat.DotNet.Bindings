public enum RCAttributionNetwork
{
	AppleSearchAds = 0,
	Adjust = 1,
	AppsFlyer = 2,
	Branch = 3,
	Tenjin = 4,
	Facebook = 5,
	MParticle = 6,
	AdServices = 7
}

public enum RCCacheFetchPolicy
{
	FromCacheOnly = 0,
	FetchCurrent = 1,
	NotStaleCachedOrFetched = 2,
	CachedOrFetched = 3
}

public enum RCEntitlementVerificationMode
{
	Disabled = 0,
	Informational = 1,
	Enforced = 2
}

public enum RCPurchasesErrorCode
{
	UnknownError = 0,
	PurchaseCancelledError = 1,
	StoreProblemError = 2,
	PurchaseNotAllowedError = 3,
	PurchaseInvalidError = 4,
	ProductNotAvailableForPurchaseError = 5,
	ProductAlreadyPurchasedError = 6,
	ReceiptAlreadyInUseError = 7,
	InvalidReceiptError = 8,
	MissingReceiptFileError = 9,
	NetworkError = 10,
	InvalidCredentialsError = 11,
	UnexpectedBackendResponseError = 12,
	ReceiptInUseByOtherSubscriberError = 13,
	InvalidAppUserIdError = 14,
	OperationAlreadyInProgressForProductError = 15,
	UnknownBackendError = 16,
	InvalidAppleSubscriptionKeyError = 17,
	IneligibleError = 18,
	InsufficientPermissionsError = 19,
	PaymentPendingError = 20,
	InvalidSubscriberAttributesError = 21,
	LogOutAnonymousUserError = 22,
	ConfigurationError = 23,
	UnsupportedError = 24,
	EmptySubscriberAttributesError = 25,
	ProductDiscountMissingIdentifierError = 26,
	ProductDiscountMissingSubscriptionGroupIdentifierError = 28,
	CustomerInfoError = 29,
	SystemInfoError = 30,
	BeginRefundRequestError = 31,
	ProductRequestTimedOut = 32,
	APIEndpointBlocked = 33,
	InvalidPromotionalOfferError = 34,
	OfflineConnectionError = 35,
	FeatureNotAvailableInCustomEntitlementsComputationMode = 36,
	SignatureVerificationFailed = 37,
	FeatureNotSupportedWithStoreKit1 = 38,
	InvalidWebPurchaseToken = 39,
	PurchaseBelongsToOtherUser = 40,
	ExpiredWebPurchaseToken = 41,
	TestStoreSimulatedPurchaseError = 42
}

public enum RCIntroEligibilityStatus
{
	Unknown = 0,
	Ineligible = 1,
	Eligible = 2,
	NoIntroOfferExists = 3
}

public enum RCLogLevel
{
	Verbose = 4,
	Debug = 0,
	Info = 1,
	Warn = 2,
	Error = 3
}

public enum RCPackageType
{
	Unknown = -2,
	Custom = -1,
	Lifetime = 0,
	Annual = 1,
	SixMonth = 2,
	ThreeMonth = 3,
	TwoMonth = 4,
	Monthly = 5,
	Weekly = 6
}

public enum RCPeriodType
{
	Normal = 0,
	Intro = 1,
	Trial = 2,
	Prepaid = 3
}

public enum RCPurchaseOwnershipType
{
	Purchased = 0,
	FamilyShared = 1,
	Unknown = 2
}

public enum RCPurchasesAreCompletedBy
{
	RevenueCat = 0,
	MyApp = 1
}

public enum RCRefundRequestStatus
{
	UserCancelled = 0,
	Success = 1,
	Error = 2
}

public enum RCStore
{
	AppStore = 0,
	MacAppStore = 1,
	PlayStore = 2,
	Stripe = 3,
	Promotional = 4,
	UnknownStore = 5,
	Amazon = 6,
	Billing = 7,
	External = 8,
	Paddle = 9,
	TestStore = 10
}

public enum RCStoreKitVersion
{
	RCStoreKitVersion1 = 1,
	RCStoreKitVersion2 = 2
}

public enum RCStoreMessageType
{
	BillingIssue = 0,
	PriceIncreaseConsent = 1,
	Generic = 2,
	WinBackOffer = 3
}

public enum RCStoreProductCategory
{
	Subscription = 0,
	NonSubscription = 1
}

public enum RCStoreProductType
{
	Consumable = 0,
	NonConsumable = 1,
	NonRenewableSubscription = 2,
	AutoRenewableSubscription = 3
}

public enum RCPaymentMode
{
	PayAsYouGo = 0,
	PayUpFront = 1,
	FreeTrial = 2
}

public enum RCDiscountType
{
	Introductory = 0,
	Promotional = 1,
	WinBack = 2
}

public enum RCSubscriptionPeriodUnit
{
	Day = 0,
	Week = 1,
	Month = 2,
	Year = 3
}

public enum RCVerificationResult
{
	NotRequested = 0,
	Verified = 1,
	VerifiedOnDevice = 3,
	Failed = 2
}
