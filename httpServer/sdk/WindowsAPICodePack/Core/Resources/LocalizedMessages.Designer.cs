﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAPICodePack.Resources {
    using System;
	using System.Linq;
	using System.Reflection;


	/// <summary>
	///   一个强类型的资源类，用于查找本地化的字符串等。
	/// </summary>
	// 此类是由 StronglyTypedResourceBuilder
	// 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
	// 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
	// (以 /str 作为命令选项)，或重新生成 VS 项目。
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedMessages() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
					var attributes = typeof(LocalizedMessages).GetTypeInfo().Assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute));
					var assemblyTitleAttribute = attributes.SingleOrDefault() as AssemblyTitleAttribute;
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager(assemblyTitleAttribute?.Title + ".sdk.WindowsAPICodePack.Resources.LocalizedMessages", typeof(LocalizedMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to register application for restart due to bad parameters. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoverFailedToRegisterForRestartBadParameters {
            get {
                return ResourceManager.GetString("ApplicationRecoverFailedToRegisterForRestartBadParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Application was not registered for recovery due to bad parameters. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryBadParameters {
            get {
                return ResourceManager.GetString("ApplicationRecoveryBadParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Application failed to register for recovery. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryFailedToRegister {
            get {
                return ResourceManager.GetString("ApplicationRecoveryFailedToRegister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Application failed to registered for restart. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryFailedToRegisterForRestart {
            get {
                return ResourceManager.GetString("ApplicationRecoveryFailedToRegisterForRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unregister for recovery failed. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryFailedToUnregister {
            get {
                return ResourceManager.GetString("ApplicationRecoveryFailedToUnregister", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unregister for restart failed. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryFailedToUnregisterForRestart {
            get {
                return ResourceManager.GetString("ApplicationRecoveryFailedToUnregisterForRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This method must be called from the registered callback method. 的本地化字符串。
        /// </summary>
        internal static string ApplicationRecoveryMustBeCalledFromCallback {
            get {
                return ResourceManager.GetString("ApplicationRecoveryMustBeCalledFromCallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ACOnline: {1}{0}Max Charge: {2} mWh{0}Current Charge: {3} mWh{0}Discharge Rate: {4} mWh{0}Estimated Time Remaining: {5}{0}Suggested Critical Battery Charge: {6} mWh{0}Suggested Battery Warning Charge: {7} mWh{0} 的本地化字符串。
        /// </summary>
        internal static string BatteryStateStringRepresentation {
            get {
                return ResourceManager.GetString("BatteryStateStringRepresentation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cancelable cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string CancelableCannotBeChanged {
            get {
                return ResourceManager.GetString("CancelableCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog caption cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string CaptionCannotBeChanged {
            get {
                return ResourceManager.GetString("CaptionCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CheckBox text cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string CheckBoxCannotBeChanged {
            get {
                return ResourceManager.GetString("CheckBoxCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Collapsed control text cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string CollapsedTextCannotBeChanged {
            get {
                return ResourceManager.GetString("CollapsedTextCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Only supported on Windows 7 or newer. 的本地化字符串。
        /// </summary>
        internal static string CoreHelpersRunningOn7 {
            get {
                return ResourceManager.GetString("CoreHelpersRunningOn7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Only supported on Windows Vista or newer. 的本地化字符串。
        /// </summary>
        internal static string CoreHelpersRunningOnVista {
            get {
                return ResourceManager.GetString("CoreHelpersRunningOnVista", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Only supported on Windows XP or newer. 的本地化字符串。
        /// </summary>
        internal static string CoreHelpersRunningOnXp {
            get {
                return ResourceManager.GetString("CoreHelpersRunningOnXp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog cannot have more than one control with the same name. 的本地化字符串。
        /// </summary>
        internal static string DialogCollectionCannotHaveDuplicateNames {
            get {
                return ResourceManager.GetString("DialogCollectionCannotHaveDuplicateNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog control must be removed from current collections first. 的本地化字符串。
        /// </summary>
        internal static string DialogCollectionControlAlreadyHosted {
            get {
                return ResourceManager.GetString("DialogCollectionControlAlreadyHosted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Control name cannot be null or zero length. 的本地化字符串。
        /// </summary>
        internal static string DialogCollectionControlNameNull {
            get {
                return ResourceManager.GetString("DialogCollectionControlNameNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Modifying controls collection while dialog is showing is not supported. 的本地化字符串。
        /// </summary>
        internal static string DialogCollectionModifyShowingDialog {
            get {
                return ResourceManager.GetString("DialogCollectionModifyShowingDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog control name cannot be empty or null. 的本地化字符串。
        /// </summary>
        internal static string DialogControlNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("DialogControlNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog controls cannot be renamed. 的本地化字符串。
        /// </summary>
        internal static string DialogControlsCannotBeRenamed {
            get {
                return ResourceManager.GetString("DialogControlsCannotBeRenamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Application 的本地化字符串。
        /// </summary>
        internal static string DialogDefaultCaption {
            get {
                return ResourceManager.GetString("DialogDefaultCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        internal static string DialogDefaultContent {
            get {
                return ResourceManager.GetString("DialogDefaultContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        internal static string DialogDefaultMainInstruction {
            get {
                return ResourceManager.GetString("DialogDefaultMainInstruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expanded information mode cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string ExpandedDetailsCannotBeChanged {
            get {
                return ResourceManager.GetString("ExpandedDetailsCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expanded control label cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string ExpandedLabelCannotBeChanged {
            get {
                return ResourceManager.GetString("ExpandedLabelCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Expanding state of the dialog cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string ExpandingStateCannotBeChanged {
            get {
                return ResourceManager.GetString("ExpandingStateCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hyperlinks cannot be enabled/disabled while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string HyperlinksCannotBetSet {
            get {
                return ResourceManager.GetString("HyperlinksCannotBetSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Reference path is invalid. 的本地化字符串。
        /// </summary>
        internal static string InvalidReferencePath {
            get {
                return ResourceManager.GetString("InvalidReferencePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The specified event handler has not been registered. 的本地化字符串。
        /// </summary>
        internal static string MessageManagerHandlerNotRegistered {
            get {
                return ResourceManager.GetString("MessageManagerHandlerNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An error has occurred in dialog configuration. 的本地化字符串。
        /// </summary>
        internal static string NativeTaskDialogConfigurationError {
            get {
                return ResourceManager.GetString("NativeTaskDialogConfigurationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid arguments to Win32 call. 的本地化字符串。
        /// </summary>
        internal static string NativeTaskDialogInternalErrorArgs {
            get {
                return ResourceManager.GetString("NativeTaskDialogInternalErrorArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog contents too complex. 的本地化字符串。
        /// </summary>
        internal static string NativeTaskDialogInternalErrorComplex {
            get {
                return ResourceManager.GetString("NativeTaskDialogInternalErrorComplex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An unexpected internal error occurred in the Win32 call: {0:x} 的本地化字符串。
        /// </summary>
        internal static string NativeTaskDialogInternalErrorUnexpected {
            get {
                return ResourceManager.GetString("NativeTaskDialogInternalErrorUnexpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 TaskDialog feature needs to load version 6 of comctl32.dll but a different version is current loaded in memory. 的本地化字符串。
        /// </summary>
        internal static string NativeTaskDialogVersionError {
            get {
                return ResourceManager.GetString("NativeTaskDialogVersionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog owner cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string OwnerCannotBeChanged {
            get {
                return ResourceManager.GetString("OwnerCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 SetThreadExecutionState call failed. 的本地化字符串。
        /// </summary>
        internal static string PowerExecutionStateFailed {
            get {
                return ResourceManager.GetString("PowerExecutionStateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The caller had insufficient access rights to get the system battery state. 的本地化字符串。
        /// </summary>
        internal static string PowerInsufficientAccessBatteryState {
            get {
                return ResourceManager.GetString("PowerInsufficientAccessBatteryState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The caller had insufficient access rights to get the system power capabilities. 的本地化字符串。
        /// </summary>
        internal static string PowerInsufficientAccessCapabilities {
            get {
                return ResourceManager.GetString("PowerInsufficientAccessCapabilities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to get active power scheme. 的本地化字符串。
        /// </summary>
        internal static string PowerManagerActiveSchemeFailed {
            get {
                return ResourceManager.GetString("PowerManagerActiveSchemeFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Battery is not present on this system. 的本地化字符串。
        /// </summary>
        internal static string PowerManagerBatteryNotPresent {
            get {
                return ResourceManager.GetString("PowerManagerBatteryNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Progress bar cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string ProgressBarCannotBeChanged {
            get {
                return ResourceManager.GetString("ProgressBarCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Progress bar cannot be hosted in multiple dialogs. 的本地化字符串。
        /// </summary>
        internal static string ProgressBarCannotBeHostedInMultipleDialogs {
            get {
                return ResourceManager.GetString("ProgressBarCannotBeHostedInMultipleDialogs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}, {1} 的本地化字符串。
        /// </summary>
        internal static string PropertyKeyFormatString {
            get {
                return ResourceManager.GetString("PropertyKeyFormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to initialize PropVariant. 的本地化字符串。
        /// </summary>
        internal static string PropVariantInitializationError {
            get {
                return ResourceManager.GetString("PropVariantInitializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Multi-dimensional SafeArrays not supported. 的本地化字符串。
        /// </summary>
        internal static string PropVariantMultiDimArray {
            get {
                return ResourceManager.GetString("PropVariantMultiDimArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 String argument cannot be null or empty. 的本地化字符串。
        /// </summary>
        internal static string PropVariantNullString {
            get {
                return ResourceManager.GetString("PropVariantNullString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This Value type is not supported. 的本地化字符串。
        /// </summary>
        internal static string PropVariantTypeNotSupported {
            get {
                return ResourceManager.GetString("PropVariantTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot be cast to unsupported type. 的本地化字符串。
        /// </summary>
        internal static string PropVariantUnsupportedType {
            get {
                return ResourceManager.GetString("PropVariantUnsupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 delegate: {0}, state: {1}, ping: {2} 的本地化字符串。
        /// </summary>
        internal static string RecoverySettingsFormatString {
            get {
                return ResourceManager.GetString("RecoverySettingsFormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 command: {0} restrictions: {1} 的本地化字符串。
        /// </summary>
        internal static string RestartSettingsFormatString {
            get {
                return ResourceManager.GetString("RestartSettingsFormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 StandardButtons cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string StandardButtonsCannotBeChanged {
            get {
                return ResourceManager.GetString("StandardButtonsCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Startup location cannot be changed while dialog is showing. 的本地化字符串。
        /// </summary>
        internal static string StartupLocationCannotBeChanged {
            get {
                return ResourceManager.GetString("StartupLocationCannotBeChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Bad button ID in closing event. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogBadButtonId {
            get {
                return ResourceManager.GetString("TaskDialogBadButtonId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Button text must be non-empty. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogButtonTextEmpty {
            get {
                return ResourceManager.GetString("TaskDialogButtonTextEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Check box text must be provided to enable the dialog check box. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogCheckBoxTextRequiredToEnableCheckBox {
            get {
                return ResourceManager.GetString("TaskDialogCheckBoxTextRequiredToEnableCheckBox", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempting to close a non-showing dialog. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogCloseNonShowing {
            get {
                return ResourceManager.GetString("TaskDialogCloseNonShowing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Application 的本地化字符串。
        /// </summary>
        internal static string TaskDialogDefaultCaption {
            get {
                return ResourceManager.GetString("TaskDialogDefaultCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        internal static string TaskDialogDefaultContent {
            get {
                return ResourceManager.GetString("TaskDialogDefaultContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似  的本地化字符串。
        /// </summary>
        internal static string TaskDialogDefaultMainInstruction {
            get {
                return ResourceManager.GetString("TaskDialogDefaultMainInstruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot have more than one default button of a given type. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogOnlyOneDefaultControl {
            get {
                return ResourceManager.GetString("TaskDialogOnlyOneDefaultControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Maximum value provided must be greater than the minimum value. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogProgressBarMaxValueGreaterThanMin {
            get {
                return ResourceManager.GetString("TaskDialogProgressBarMaxValueGreaterThanMin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Minimum value provided must be a positive number. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogProgressBarMinValueGreaterThanZero {
            get {
                return ResourceManager.GetString("TaskDialogProgressBarMinValueGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Minimum value provided must less than the maximum value. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogProgressBarMinValueLessThanMax {
            get {
                return ResourceManager.GetString("TaskDialogProgressBarMinValueLessThanMax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Value provided must be greater than equal to the minimum value and less than the maximum value. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogProgressBarValueInRange {
            get {
                return ResourceManager.GetString("TaskDialogProgressBarValueInRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog cannot display both non-standard buttons and standard buttons. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogSupportedButtonsAndButtons {
            get {
                return ResourceManager.GetString("TaskDialogSupportedButtonsAndButtons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Dialog cannot display both non-standard buttons and command links. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogSupportedButtonsAndLinks {
            get {
                return ResourceManager.GetString("TaskDialogSupportedButtonsAndLinks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unknown dialog control type. 的本地化字符串。
        /// </summary>
        internal static string TaskDialogUnkownControl {
            get {
                return ResourceManager.GetString("TaskDialogUnkownControl", resourceCulture);
            }
        }
    }
}
