﻿namespace BootstrapMvc
{
    using System;
    using BootstrapMvc.Core;

    public static class ButtonExtensions
    {
        #region Fluent

        public static IItemWriter<T, AnyContent> Type<T>(this IItemWriter<T, AnyContent> target, ButtonType value) 
            where T : Button
        {
            target.Item.Type = value;
            return target;
        }

        public static IItemWriter<T, AnyContent> BlockSize<T>(this IItemWriter<T, AnyContent> target, bool value = true) 
            where T : Button
        {
            target.Item.BlockSize = value;
            return target;
        }

        #endregion

        #region Generation

        private static IItemWriter<Button, AnyContent> Button(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<Button, AnyContent>();
        }

        public static IItemWriter<Button, AnyContent> Button(this IAnyContentMarker contentHelper, object content)
        {
            return Button(contentHelper).Content(content);
        }

        public static IItemWriter<Button, AnyContent> Button(this IAnyContentMarker contentHelper, ButtonType type, object content)
        {
            return Button(contentHelper).Type(type).Content(content);
        }

        public static IItemWriter<Button, AnyContent> Button(this IAnyContentMarker contentHelper, ButtonType type, params object[] contents)
        {
            return Button(contentHelper).Type(type).Content(contents);
        }

        #endregion
    }
}
