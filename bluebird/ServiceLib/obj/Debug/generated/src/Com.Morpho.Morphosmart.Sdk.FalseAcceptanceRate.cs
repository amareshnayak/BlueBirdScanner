using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/FalseAcceptanceRate", DoNotGenerateAcw=true)]
	public partial class FalseAcceptanceRate : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_0']"
		[Register ("MORPHO_FAR_0")]
		public const int MorphoFar0 = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_1']"
		[Register ("MORPHO_FAR_1")]
		public const int MorphoFar1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_10']"
		[Register ("MORPHO_FAR_10")]
		public const int MorphoFar10 = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_2']"
		[Register ("MORPHO_FAR_2")]
		public const int MorphoFar2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_3']"
		[Register ("MORPHO_FAR_3")]
		public const int MorphoFar3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_4']"
		[Register ("MORPHO_FAR_4")]
		public const int MorphoFar4 = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_5']"
		[Register ("MORPHO_FAR_5")]
		public const int MorphoFar5 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_6']"
		[Register ("MORPHO_FAR_6")]
		public const int MorphoFar6 = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_7']"
		[Register ("MORPHO_FAR_7")]
		public const int MorphoFar7 = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_8']"
		[Register ("MORPHO_FAR_8")]
		public const int MorphoFar8 = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FalseAcceptanceRate']/field[@name='MORPHO_FAR_9']"
		[Register ("MORPHO_FAR_9")]
		public const int MorphoFar9 = (int) 9;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/FalseAcceptanceRate", typeof (FalseAcceptanceRate));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected FalseAcceptanceRate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
