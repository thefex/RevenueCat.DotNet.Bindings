# Create xcode project that use pods for RevenueCat

Pod should install following

platform :ios, '16.0' # or higher
use_frameworks!

target 'revenuecatbindings' do
  pod 'RevenueCat'
  pod 'RevenueCatUI'
end

# Got pod and xcode proj? Now build
Build it twice - one using debug configuration and one using release configuration.
Build it using Library for distribution.

Build it into temporary folder here - temporary-debug and temporary-release.

# Create xcframework so it works on both iPhone and simulator.

xcodebuild -create-xcframework -framework path-from-your-xcode-derived-path/Release-iphoneos/RevenueCat.framework -framework Release-path-from-your-xcode-derived-path/RevenueCat.framework -output ./RevenueCat.xcframework

# Generate ApiDefinitions / enums
Bind RevenueCat and RevenueCatUI frameworks using sharpie. Store output in folders RevenueCat-bindings and RevenueCatUI-bindings

sharpie bind Release-iphoneos/RevenueCat.framework/Headers/RevenueCat.. --sdk iphoneos16.2
