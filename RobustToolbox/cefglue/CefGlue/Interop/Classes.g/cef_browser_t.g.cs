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
    internal unsafe struct cef_browser_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_browser_t*, int> _is_valid;
        internal delegate* unmanaged<cef_browser_t*, cef_browser_host_t*> _get_host;
        internal delegate* unmanaged<cef_browser_t*, int> _can_go_back;
        internal delegate* unmanaged<cef_browser_t*, void> _go_back;
        internal delegate* unmanaged<cef_browser_t*, int> _can_go_forward;
        internal delegate* unmanaged<cef_browser_t*, void> _go_forward;
        internal delegate* unmanaged<cef_browser_t*, int> _is_loading;
        internal delegate* unmanaged<cef_browser_t*, void> _reload;
        internal delegate* unmanaged<cef_browser_t*, void> _reload_ignore_cache;
        internal delegate* unmanaged<cef_browser_t*, void> _stop_load;
        internal delegate* unmanaged<cef_browser_t*, int> _get_identifier;
        internal delegate* unmanaged<cef_browser_t*, cef_browser_t*, int> _is_same;
        internal delegate* unmanaged<cef_browser_t*, int> _is_popup;
        internal delegate* unmanaged<cef_browser_t*, int> _has_document;
        internal delegate* unmanaged<cef_browser_t*, cef_frame_t*> _get_main_frame;
        internal delegate* unmanaged<cef_browser_t*, cef_frame_t*> _get_focused_frame;
        internal delegate* unmanaged<cef_browser_t*, long, cef_frame_t*> _get_frame_byident;
        internal delegate* unmanaged<cef_browser_t*, cef_string_t*, cef_frame_t*> _get_frame;
        internal delegate* unmanaged<cef_browser_t*, UIntPtr> _get_frame_count;
        internal delegate* unmanaged<cef_browser_t*, UIntPtr*, long*, void> _get_frame_identifiers;
        internal delegate* unmanaged<cef_browser_t*, cef_string_list*, void> _get_frame_names;
        
        // AddRef
        
        public static void add_ref(cef_browser_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_browser_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_browser_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_browser_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_browser_t* self)
        {
            return self->_is_valid(self);
        }
        
        // GetHost
        
        public static cef_browser_host_t* get_host(cef_browser_t* self)
        {
            return self->_get_host(self);
        }
        
        // CanGoBack
        
        public static int can_go_back(cef_browser_t* self)
        {
            return self->_can_go_back(self);
        }
        
        // GoBack
        
        public static void go_back(cef_browser_t* self)
        {
            self->_go_back(self);
        }
        
        // CanGoForward
        
        public static int can_go_forward(cef_browser_t* self)
        {
            return self->_can_go_forward(self);
        }
        
        // GoForward
        
        public static void go_forward(cef_browser_t* self)
        {
            self->_go_forward(self);
        }
        
        // IsLoading
        
        public static int is_loading(cef_browser_t* self)
        {
            return self->_is_loading(self);
        }
        
        // Reload
        
        public static void reload(cef_browser_t* self)
        {
            self->_reload(self);
        }
        
        // ReloadIgnoreCache
        
        public static void reload_ignore_cache(cef_browser_t* self)
        {
            self->_reload_ignore_cache(self);
        }
        
        // StopLoad
        
        public static void stop_load(cef_browser_t* self)
        {
            self->_stop_load(self);
        }
        
        // GetIdentifier
        
        public static int get_identifier(cef_browser_t* self)
        {
            return self->_get_identifier(self);
        }
        
        // IsSame
        
        public static int is_same(cef_browser_t* self, cef_browser_t* that)
        {
            return self->_is_same(self, that);
        }
        
        // IsPopup
        
        public static int is_popup(cef_browser_t* self)
        {
            return self->_is_popup(self);
        }
        
        // HasDocument
        
        public static int has_document(cef_browser_t* self)
        {
            return self->_has_document(self);
        }
        
        // GetMainFrame
        
        public static cef_frame_t* get_main_frame(cef_browser_t* self)
        {
            return self->_get_main_frame(self);
        }
        
        // GetFocusedFrame
        
        public static cef_frame_t* get_focused_frame(cef_browser_t* self)
        {
            return self->_get_focused_frame(self);
        }
        
        // GetFrame
        
        public static cef_frame_t* get_frame_byident(cef_browser_t* self, long identifier)
        {
            return self->_get_frame_byident(self, identifier);
        }
        
        // GetFrame
        
        public static cef_frame_t* get_frame(cef_browser_t* self, cef_string_t* name)
        {
            return self->_get_frame(self, name);
        }
        
        // GetFrameCount
        
        public static UIntPtr get_frame_count(cef_browser_t* self)
        {
            return self->_get_frame_count(self);
        }
        
        // GetFrameIdentifiers
        
        public static void get_frame_identifiers(cef_browser_t* self, UIntPtr* identifiersCount, long* identifiers)
        {
            self->_get_frame_identifiers(self, identifiersCount, identifiers);
        }
        
        // GetFrameNames
        
        public static void get_frame_names(cef_browser_t* self, cef_string_list* names)
        {
            self->_get_frame_names(self, names);
        }
        
    }
}