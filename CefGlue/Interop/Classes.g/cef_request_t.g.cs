﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_request_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _is_read_only;
        internal IntPtr _get_url;
        internal IntPtr _set_url;
        internal IntPtr _get_method;
        internal IntPtr _set_method;
        internal IntPtr _set_referrer;
        internal IntPtr _get_referrer_url;
        internal IntPtr _get_referrer_policy;
        internal IntPtr _get_post_data;
        internal IntPtr _set_post_data;
        internal IntPtr _get_header_map;
        internal IntPtr _set_header_map;
        internal IntPtr _set;
        internal IntPtr _get_flags;
        internal IntPtr _set_flags;
        internal IntPtr _get_first_party_for_cookies;
        internal IntPtr _set_first_party_for_cookies;
        internal IntPtr _get_resource_type;
        internal IntPtr _get_transition_type;
        internal IntPtr _get_identifier;
        
        // Create
        [DllImport(libcef.DllName, EntryPoint = "cef_request_create", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_request_t* create();
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_read_only_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_url_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_url_delegate(cef_request_t* self, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_method_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_method_delegate(cef_request_t* self, cef_string_t* method);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_referrer_delegate(cef_request_t* self, cef_string_t* referrer_url, CefReferrerPolicy policy);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_referrer_url_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefReferrerPolicy get_referrer_policy_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_post_data_t* get_post_data_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_post_data_delegate(cef_request_t* self, cef_post_data_t* postData);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_header_map_delegate(cef_request_t* self, cef_string_multimap* headerMap);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_header_map_delegate(cef_request_t* self, cef_string_multimap* headerMap);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_delegate(cef_request_t* self, cef_string_t* url, cef_string_t* method, cef_post_data_t* postData, cef_string_multimap* headerMap);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_flags_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_flags_delegate(cef_request_t* self, int flags);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_first_party_for_cookies_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void set_first_party_for_cookies_delegate(cef_request_t* self, cef_string_t* url);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefResourceType get_resource_type_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefTransitionType get_transition_type_delegate(cef_request_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate ulong get_identifier_delegate(cef_request_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_request_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_request_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_request_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsReadOnly
        private static IntPtr _p3;
        private static is_read_only_delegate _d3;
        
        public static int is_read_only(cef_request_t* self)
        {
            is_read_only_delegate d;
            var p = self->_is_read_only;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_read_only_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_read_only_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetURL
        private static IntPtr _p4;
        private static get_url_delegate _d4;
        
        public static cef_string_userfree* get_url(cef_request_t* self)
        {
            get_url_delegate d;
            var p = self->_get_url;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_url_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // SetURL
        private static IntPtr _p5;
        private static set_url_delegate _d5;
        
        public static void set_url(cef_request_t* self, cef_string_t* url)
        {
            set_url_delegate d;
            var p = self->_set_url;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (set_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_url_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            d(self, url);
        }
        
        // GetMethod
        private static IntPtr _p6;
        private static get_method_delegate _d6;
        
        public static cef_string_userfree* get_method(cef_request_t* self)
        {
            get_method_delegate d;
            var p = self->_get_method;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (get_method_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_method_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // SetMethod
        private static IntPtr _p7;
        private static set_method_delegate _d7;
        
        public static void set_method(cef_request_t* self, cef_string_t* method)
        {
            set_method_delegate d;
            var p = self->_set_method;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (set_method_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_method_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            d(self, method);
        }
        
        // SetReferrer
        private static IntPtr _p8;
        private static set_referrer_delegate _d8;
        
        public static void set_referrer(cef_request_t* self, cef_string_t* referrer_url, CefReferrerPolicy policy)
        {
            set_referrer_delegate d;
            var p = self->_set_referrer;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (set_referrer_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_referrer_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            d(self, referrer_url, policy);
        }
        
        // GetReferrerURL
        private static IntPtr _p9;
        private static get_referrer_url_delegate _d9;
        
        public static cef_string_userfree* get_referrer_url(cef_request_t* self)
        {
            get_referrer_url_delegate d;
            var p = self->_get_referrer_url;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_referrer_url_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_referrer_url_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // GetReferrerPolicy
        private static IntPtr _pa;
        private static get_referrer_policy_delegate _da;
        
        public static CefReferrerPolicy get_referrer_policy(cef_request_t* self)
        {
            get_referrer_policy_delegate d;
            var p = self->_get_referrer_policy;
            if (p == _pa) { d = _da; }
            else
            {
                d = (get_referrer_policy_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_referrer_policy_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self);
        }
        
        // GetPostData
        private static IntPtr _pb;
        private static get_post_data_delegate _db;
        
        public static cef_post_data_t* get_post_data(cef_request_t* self)
        {
            get_post_data_delegate d;
            var p = self->_get_post_data;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_post_data_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_post_data_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // SetPostData
        private static IntPtr _pc;
        private static set_post_data_delegate _dc;
        
        public static void set_post_data(cef_request_t* self, cef_post_data_t* postData)
        {
            set_post_data_delegate d;
            var p = self->_set_post_data;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (set_post_data_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_post_data_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            d(self, postData);
        }
        
        // GetHeaderMap
        private static IntPtr _pd;
        private static get_header_map_delegate _dd;
        
        public static void get_header_map(cef_request_t* self, cef_string_multimap* headerMap)
        {
            get_header_map_delegate d;
            var p = self->_get_header_map;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (get_header_map_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_header_map_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            d(self, headerMap);
        }
        
        // SetHeaderMap
        private static IntPtr _pe;
        private static set_header_map_delegate _de;
        
        public static void set_header_map(cef_request_t* self, cef_string_multimap* headerMap)
        {
            set_header_map_delegate d;
            var p = self->_set_header_map;
            if (p == _pe) { d = _de; }
            else
            {
                d = (set_header_map_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_header_map_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            d(self, headerMap);
        }
        
        // Set
        private static IntPtr _pf;
        private static set_delegate _df;
        
        public static void set(cef_request_t* self, cef_string_t* url, cef_string_t* method, cef_post_data_t* postData, cef_string_multimap* headerMap)
        {
            set_delegate d;
            var p = self->_set;
            if (p == _pf) { d = _df; }
            else
            {
                d = (set_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            d(self, url, method, postData, headerMap);
        }
        
        // GetFlags
        private static IntPtr _p10;
        private static get_flags_delegate _d10;
        
        public static int get_flags(cef_request_t* self)
        {
            get_flags_delegate d;
            var p = self->_get_flags;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (get_flags_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_flags_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self);
        }
        
        // SetFlags
        private static IntPtr _p11;
        private static set_flags_delegate _d11;
        
        public static void set_flags(cef_request_t* self, int flags)
        {
            set_flags_delegate d;
            var p = self->_set_flags;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (set_flags_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_flags_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            d(self, flags);
        }
        
        // GetFirstPartyForCookies
        private static IntPtr _p12;
        private static get_first_party_for_cookies_delegate _d12;
        
        public static cef_string_userfree* get_first_party_for_cookies(cef_request_t* self)
        {
            get_first_party_for_cookies_delegate d;
            var p = self->_get_first_party_for_cookies;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (get_first_party_for_cookies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_first_party_for_cookies_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self);
        }
        
        // SetFirstPartyForCookies
        private static IntPtr _p13;
        private static set_first_party_for_cookies_delegate _d13;
        
        public static void set_first_party_for_cookies(cef_request_t* self, cef_string_t* url)
        {
            set_first_party_for_cookies_delegate d;
            var p = self->_set_first_party_for_cookies;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (set_first_party_for_cookies_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_first_party_for_cookies_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            d(self, url);
        }
        
        // GetResourceType
        private static IntPtr _p14;
        private static get_resource_type_delegate _d14;
        
        public static CefResourceType get_resource_type(cef_request_t* self)
        {
            get_resource_type_delegate d;
            var p = self->_get_resource_type;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_resource_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_resource_type_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self);
        }
        
        // GetTransitionType
        private static IntPtr _p15;
        private static get_transition_type_delegate _d15;
        
        public static CefTransitionType get_transition_type(cef_request_t* self)
        {
            get_transition_type_delegate d;
            var p = self->_get_transition_type;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (get_transition_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_transition_type_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            return d(self);
        }
        
        // GetIdentifier
        private static IntPtr _p16;
        private static get_identifier_delegate _d16;
        
        public static ulong get_identifier(cef_request_t* self)
        {
            get_identifier_delegate d;
            var p = self->_get_identifier;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_identifier_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_identifier_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            return d(self);
        }
        
    }
}
