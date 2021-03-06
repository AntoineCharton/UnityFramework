﻿using UnityEngine;

namespace Framework.Settings
{
    /// <summary>
    /// A grouping used to organize related settings.
    /// </summary>
    [CreateAssetMenu(fileName = "New Category", menuName = "Framework/Settings/Category", order = 50)]
    public class SettingCategory : ScriptableObject
    {
        [SerializeField]
        [Tooltip("The icon used to represent this category in the game UI.")]
        private Sprite m_icon = null;

        /// <summary>
        /// The icon used to represent this category in the game UI.
        /// </summary>
        public Sprite Icon => m_icon;

        [SerializeField]
        [Tooltip("The sorting order of the category in the category list. " +
            "Categories with lesser sorting orders are first.")]
        private int m_sortOrder = 100;

        /// <summary>
        /// The sorting order of the category in the category list. Categories with
        /// lesser sorting orders are first.
        /// </summary>
        public int SortOrder => m_sortOrder;
    }
}
