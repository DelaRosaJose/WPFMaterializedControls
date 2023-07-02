using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace WPFMaterializedControls
{
    public class MaterializedTextboxNumerico : Border
    {
        #region Creacion de Objetos

        readonly TextBlock _textBlock = new TextBlock()
        {
            Padding = new Thickness(5, 0, 0, 0),
        };

        readonly TextBox _textBox = new TextBox();

        private readonly DockPanel _dockPanel = new DockPanel();

        #endregion

        #region Propiedades Label
        public string Title
        {
            get { return _textBlock.Text; }
            set { _textBlock.Text = value; }
        }

        public TextAlignment LabelTextAlignment
        {
            get { return _textBlock.TextAlignment; }
            set { _textBlock.TextAlignment = value; }
        }

        public Brush LabelBackground
        {
            get { return _textBlock.Background; }
            set { _textBlock.Background = value; }
        }

        public FontWeight LabelFontWeight
        {
            get { return _textBlock.FontWeight; }
            set { _textBlock.FontWeight = value; }
        }
        public FontStretch LabelFontStretch
        {
            get { return _textBlock.FontStretch; }
            set { _textBlock.FontStretch = value; }
        }
        public FontStyle LabelFontStyle
        {
            get { return _textBlock.FontStyle; }
            set { _textBlock.FontStyle = value; }
        }
        public double LabelFontSize
        {
            get { return _textBlock.FontSize; }
            set { _textBlock.FontSize = value; }
        }
        public FontFamily LabelFontFamily
        {
            get { return _textBlock.FontFamily; }
            set { _textBlock.FontFamily = value; }
        }

        #endregion

        #region Propiedades del Textbox

        public int TextBoxMaxLength
        {
            get { return _textBox.MaxLength; }
            set { _textBox.MaxLength = value; }
        }

        public Brush TextBoxBackground
        {
            get { return _textBox.Background; }
            set { _textBox.Background = value; }
        }

        public Thickness TextBoxBorderThickness
        {
            get { return _textBox.BorderThickness; }
            set { _textBox.BorderThickness = value; }
        }

        public Brush TextBoxBorderBrush
        {
            get { return _textBox.BorderBrush; }
            set { _textBox.BorderBrush = value; }
        }

        public string Text
        {
            get { return _textBox.Text; }
            set { _textBox.Text = value; }
        }

        public TextBoxStyles TextBoxStyle
        {
            set { _textBox.Style = Application.Current.FindResource(value.ToString()) as Style; }
        }

        #endregion

        #region Creacion de estilos
        public enum TextBoxStyles
        {
            MaterialDesignTextBoxBase,
            MaterialDesignTextBox,
            MaterialDesignOutlinedTextBox,
            //MaterialDesignFloatingHintTextBox,
            MaterialDesignFilledTextBox
        }

        public enum TextBoxDiseños
        {
            PrimerDiseño,
            SegundoDiseño,
            TercerDiseño
        }

        #endregion

        public TextBoxDiseños TextBoxDiseño
        {
            //set
            //{
            //    if (value != TextBoxDiseños.PrimerDiseño)
            //    {
            //        _textBlock.Visibility = Visibility.Hidden;
            //    }
            //}
            set { SetPropertyField(value/*, ref _property1, value*/); }
            get { return TextBoxDiseño; }
        }

        protected void SetPropertyField/*<T>*/(TextBoxDiseños DesingOfElement/*, ref T field, T newValue*/)
        {
            if (DesingOfElement == null)
                return;

            if (DesingOfElement != TextBoxDiseños.PrimerDiseño)
            {
                _textBlock.Visibility = Visibility.Hidden;
            }

            //if (!EqualityComparer<T>.Default.Equals(field, newValue))
            //{
            //    field = newValue;
            //    //OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
            //}
        }


        public MaterializedTextboxNumerico()
        {
            DockPanel.SetDock(_textBlock, Dock.Top);
            _dockPanel.Children.Add(_textBlock);
            _dockPanel.Children.Add(_textBox);

            // Asignamos un tamaño estandar al Control.
            this.Width = 150;
            this.Height = 50;

            //Asignamos el Elemento que cramos al control.
            this.Child = _dockPanel;
        }

    }
}
