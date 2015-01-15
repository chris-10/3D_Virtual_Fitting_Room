﻿using KinectFittingRoom.ViewModel.ClothingItems;
using System.Drawing;

namespace KinectFittingRoom.ViewModel.ButtonItems.TopMenuButtons
{
    class MoveDownButtonViewModel : TopMenuButtonViewModel
    {
        #region Consts
        private const double MoveFactor = 5;
        #endregion
        #region .ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveDownButtonViewModel"/> class.
        /// </summary>
        /// <param name="image">Image of button</param>
        public MoveDownButtonViewModel(Bitmap image)
            : base(image)
        { }
        #endregion
        #region Methods
        /// <summary>
        /// Moves last added item down
        /// </summary>
        public override void ClickEventExecuted()
        {
            if (ClothingManager.Instance.ChosenClothesModels.Count != 0)
                ClothingManager.Instance.ChangeImagePosition(MoveFactor);
        }
        #endregion
    }
}