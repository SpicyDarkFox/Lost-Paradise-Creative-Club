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
    internal unsafe struct cef_stream_writer_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_stream_writer_t*, void*, UIntPtr, UIntPtr, UIntPtr> _write;
        internal delegate* unmanaged<cef_stream_writer_t*, long, int, int> _seek;
        internal delegate* unmanaged<cef_stream_writer_t*, long> _tell;
        internal delegate* unmanaged<cef_stream_writer_t*, int> _flush;
        internal delegate* unmanaged<cef_stream_writer_t*, int> _may_block;
        
        // CreateForFile
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_writer_create_for_file", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_writer_t* create_for_file(cef_string_t* fileName);
        
        // CreateForHandler
        [DllImport(libcef.DllName, EntryPoint = "cef_stream_writer_create_for_handler", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_stream_writer_t* create_for_handler(cef_write_handler_t* handler);
        
        // AddRef
        
        public static void add_ref(cef_stream_writer_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_stream_writer_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_stream_writer_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_stream_writer_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // Write
        
        public static UIntPtr write(cef_stream_writer_t* self, void* ptr, UIntPtr size, UIntPtr n)
        {
            return self->_write(self, ptr, size, n);
        }
        
        // Seek
        
        public static int seek(cef_stream_writer_t* self, long offset, int whence)
        {
            return self->_seek(self, offset, whence);
        }
        
        // Tell
        
        public static long tell(cef_stream_writer_t* self)
        {
            return self->_tell(self);
        }
        
        // Flush
        
        public static int flush(cef_stream_writer_t* self)
        {
            return self->_flush(self);
        }
        
        // MayBlock
        
        public static int may_block(cef_stream_writer_t* self)
        {
            return self->_may_block(self);
        }
        
    }
}