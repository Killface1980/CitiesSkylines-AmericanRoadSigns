﻿using ColossalFramework.UI;
using UnityEngine;

namespace AmericanRoadSigns.GUI
{
    public class UITextureItem : UIPanel, IUIFastListRow
    {
        private UILabel _name;
        //private UILabel _size;
        private Texture2D _texture;
        
        public Texture2D texture;

        protected override void OnSizeChanged()
        {
            base.OnSizeChanged();

            if (_name == null) return;
            //_size.relativePosition = new Vector3(width - 35f, 5);
        }

        private void SetupControls()
        {
            if (_name != null) return;

            isVisible = true;
            isInteractive = true;
            width = parent.width;
            height = 30;
            height = 24;

            _name = AddUIComponent<UILabel>();
            _name.name = "TextureName";
            _name.relativePosition = new Vector3(5, 6);
            _name.textColor = new Color32(238, 238, 238, 255);
            _name.textScale = 0.8f;

            //_size = AddUIComponent<UILabel>();
            //_size.width = 30;
            //_size.textAlignment = UIHorizontalAlignment.Center;
            //_size.textColor = new Color32(170, 170, 170, 255);
            //_size.relativePosition = new Vector3(width - 35f, 5);
        }

        protected override void OnMouseDown(UIMouseEventParameter p)
        {
            p.Use();

            base.OnMouseDown(p);
        }

        protected override void OnMouseEnter(UIMouseEventParameter p)
        {
            base.OnMouseEnter(p);
        }

        protected override void OnMouseLeave(UIMouseEventParameter p)
        {
            base.OnMouseLeave(p);
        }

        #region IUIFastListRow implementation
        public void Display(object data, bool isRowOdd)
        {
            SetupControls();

            _texture = data as Texture2D;
            _name.text = _texture.name;
            backgroundSprite = null;
        }

        public void Select(bool isRowOdd)
        {
            backgroundSprite = "ListItemHighlight";
            color = new Color32(255, 255, 255, 255);
        }

        public void Deselect(bool isRowOdd)
        {
            backgroundSprite = null;
        }
        #endregion
    }
}
