using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Pipe {

	[Register ("com/morpho/morphosmart/pipe/IMsoPipeConstants", DoNotGenerateAcw=true)]
	public abstract class MsoPipeConstants : Java.Lang.Object {

		internal MsoPipeConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='COMERR_TIMEOUT_RECEIVE']"
		[Register ("COMERR_TIMEOUT_RECEIVE")]
		public const int ComerrTimeoutReceive = (int) -10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='MAX_RECV_TIME']"
		[Register ("MAX_RECV_TIME")]
		public const int MaxRecvTime = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_COMRECV']"
		[Register ("SP_PIPE_TAG_COMRECV")]
		public const sbyte SpPipeTagComrecv = (sbyte) 82;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_COMSEND']"
		[Register ("SP_PIPE_TAG_COMSEND")]
		public const sbyte SpPipeTagComsend = (sbyte) 83;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_CONNECT_MSO']"
		[Register ("SP_PIPE_TAG_CONNECT_MSO")]
		public const sbyte SpPipeTagConnectMso = (sbyte) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_MSO_LIST']"
		[Register ("SP_PIPE_TAG_MSO_LIST")]
		public const sbyte SpPipeTagMsoList = (sbyte) 76;
	}

	[Register ("com/morpho/morphosmart/pipe/IMsoPipeConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MsoPipeConstants' type. This type will be removed in a future release.")]
	public abstract class MsoPipeConstantsConsts : MsoPipeConstants {

		private MsoPipeConstantsConsts ()
		{
		}
	}

}
