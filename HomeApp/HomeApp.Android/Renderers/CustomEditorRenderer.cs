using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Mobile.Droid.Renderers;

[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]
namespace Mobile.Droid.Renderers
{
    /// <summary>
    /// Отключаем подчеркивание по умолчанию для элемента Editor на платформе  Android
    /// </summary>
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}