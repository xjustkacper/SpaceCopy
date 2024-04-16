using System;
using UnityEditor.Experimental;
using UnityEngine;

namespace UnityEditor.Tilemaps
{
    internal class GridPaintTargetsDropdown : PopupWindowContent
    {
<<<<<<< Updated upstream
        private class Styles
=======
        class Styles
>>>>>>> Stashed changes
        {
            public class IconState
            {
                public GUIContent visible;
                public GUIContent hidden;
                public GUIContent ping;
            }

            public GUIStyle menuItem = "MenuItem";
<<<<<<< Updated upstream
            public GUIContent backIcon = EditorGUIUtility.TrIconContent("tab_next");

=======
>>>>>>> Stashed changes
            public static readonly Color backgroundColor = EditorResources.GetStyle("game-object-tree-view-scene-visibility")
                .GetColor("background-color");

            public static readonly Color hoveredBackgroundColor = EditorResources.GetStyle("game-object-tree-view-scene-visibility")
                .GetColor("-unity-object-hovered-color");

            public static readonly Color selectedBackgroundColor = EditorResources.GetStyle("game-object-tree-view-scene-visibility")
                .GetColor("-unity-object-selected-color");

            public static readonly Color selectedNoFocusBackgroundColor = EditorResources.GetStyle("game-object-tree-view-scene-visibility")
                .GetColor("-unity-object-selected-no-focus-color");

            public static readonly GUIStyle sceneVisibilityStyle = "SceneVisibility";

            public static readonly IconState iconNormal = new()
            {
<<<<<<< Updated upstream
                visible = EditorGUIUtility.TrIconContent("scenevis_visible", "Click to hide Target in SceneView"),
                hidden = EditorGUIUtility.TrIconContent("scenevis_hidden", "Click to show Target in SceneView"),
                ping = EditorGUIUtility.TrIconContent("Packages/com.unity.2d.tilemap/Editor/Icons/EditorUI.Target.png", "Click to ping Target in Hierarchy"),
            };
            public static readonly IconState iconHovered = new()
            {
                visible = EditorGUIUtility.TrIconContent("scenevis_visible_hover", "Click to hide Target in SceneView"),
                hidden = EditorGUIUtility.TrIconContent("scenevis_hidden_hover", "Click to show Target in SceneView"),
                ping = EditorGUIUtility.TrIconContent("Packages/com.unity.2d.tilemap/Editor/Icons/EditorUI.TargetHover.png", "Click to ping Target in Hierarchy"),
            };

=======
                visible = EditorGUIUtility.TrIconContent("scenevis_visible"),
                hidden = EditorGUIUtility.TrIconContent("scenevis_hidden"),
                ping = EditorGUIUtility.TrIconContent("Packages/com.unity.2d.tilemap/Editor/Icons/EditorUI.Target.png"),
            };
            public static readonly IconState iconHovered = new()
            {
                visible = EditorGUIUtility.TrIconContent("scenevis_visible_hover"),
                hidden = EditorGUIUtility.TrIconContent("scenevis_hidden_hover"),
                ping = EditorGUIUtility.TrIconContent("Packages/com.unity.2d.tilemap/Editor/Icons/EditorUI.TargetHover.png"),
            };


>>>>>>> Stashed changes
            public static Color GetItemBackgroundColor(bool isHovered, bool isSelected, bool isFocused)
            {
                if (isSelected)
                {
                    if (isFocused)
                        return selectedBackgroundColor;

                    return selectedNoFocusBackgroundColor;
                }

                if (isHovered)
                    return hoveredBackgroundColor;

                return backgroundColor;
            }
        }
<<<<<<< Updated upstream

        internal static string k_CreateNewPaintTargetName = L10n.Tr("Create New Tilemap");

        private static Styles s_Styles;

        private IFlexibleMenuItemProvider m_ItemProvider;
        private FlexibleMenuModifyItemUI m_ModifyItemUI;
        private readonly Action<int, object> m_ItemClickedCallback;
        private readonly Action<int, Rect> m_ItemHoveredCallback;
        private Vector2 m_ScrollPosition = Vector2.zero;
        private bool m_ShowAddNewPresetItem;
        private int m_HoverIndex;
        private int[] m_SeperatorIndices;
        private float m_CachedWidth = -1f;
        private float m_MinTextWidth;

        private const float LineHeight = 18f;
        private const float SeperatorHeight = 8f;
        private int maxIndex { get { return m_ShowAddNewPresetItem ? m_ItemProvider.Count() : m_ItemProvider.Count() - 1; } }
=======
        static Styles s_Styles;

        IFlexibleMenuItemProvider m_ItemProvider;
        FlexibleMenuModifyItemUI m_ModifyItemUI;
        readonly Action<int, object> m_ItemClickedCallback;
        Vector2 m_ScrollPosition = Vector2.zero;
        bool m_ShowAddNewPresetItem;
        int m_HoverIndex;
        int[] m_SeperatorIndices;
        float m_CachedWidth = -1f;
        float m_MinTextWidth;

        const float LineHeight = 18f;
        const float SeparatorHeight = 8f;
        int maxIndex { get { return m_ShowAddNewPresetItem ? m_ItemProvider.Count() : m_ItemProvider.Count() - 1; } }
>>>>>>> Stashed changes
        public int selectedIndex { get; set; }
        protected float minTextWidth { get { return m_MinTextWidth; } set { m_MinTextWidth = value; ClearCachedWidth(); } }

        internal class MenuItemProvider : IFlexibleMenuItemProvider
        {
            public int Count()
            {
<<<<<<< Updated upstream
                return GridPaintingState.validTargets != null ? GridPaintingState.validTargets.Length + 1 : 1;
=======
                return GridPaintingState.validTargets != null ? GridPaintingState.validTargets.Length : 0;
>>>>>>> Stashed changes
            }

            public object GetItem(int index)
            {
<<<<<<< Updated upstream
                if (GridPaintingState.validTargets != null && index < GridPaintingState.validTargets.Length)
                    return GridPaintingState.validTargets[index];
                return GridPaintingState.scenePaintTarget;
=======
                return GridPaintingState.validTargets != null ? GridPaintingState.validTargets[index] : GridPaintingState.scenePaintTarget;
>>>>>>> Stashed changes
            }

            public int Add(object obj)
            {
                throw new NotImplementedException();
            }

            public void Replace(int index, object newPresetObject)
            {
                throw new NotImplementedException();
            }

            public void Remove(int index)
            {
                throw new NotImplementedException();
            }

            public object Create()
            {
                throw new NotImplementedException();
            }

            public void Move(int index, int destIndex, bool insertAfterDestIndex)
            {
                throw new NotImplementedException();
            }

            public string GetName(int index)
            {
<<<<<<< Updated upstream
                if (GridPaintingState.validTargets != null
                    && index < GridPaintingState.validTargets.Length)
                {
                    return GridPaintingState.validTargets[index].name;
                }
                return "Create New Tilemap";
=======
                return GridPaintingState.validTargets != null ? GridPaintingState.validTargets[index].name : GridPaintingState.scenePaintTarget.name;
>>>>>>> Stashed changes
            }

            public bool IsModificationAllowed(int index)
            {
                return false;
            }

            public int[] GetSeperatorIndices()
            {
<<<<<<< Updated upstream
                if (GridPaintingState.validTargets != null)
                    return new int[] { GridPaintingState.validTargets.Length - 1 };
                return new int[] { -1 };
=======
                return new int[0];
>>>>>>> Stashed changes
            }
        }

        // itemClickedCallback arguments is clicked index, clicked item object
<<<<<<< Updated upstream
        public GridPaintTargetsDropdown(IFlexibleMenuItemProvider itemProvider
            , int selectionIndex
            , FlexibleMenuModifyItemUI modifyItemUi
            , Action<int, object> itemClickedCallback
            , Action<int, Rect> itemHoveredCallback
            , float minWidth)
=======
        public GridPaintTargetsDropdown(IFlexibleMenuItemProvider itemProvider, int selectionIndex, FlexibleMenuModifyItemUI modifyItemUi, Action<int, object> itemClickedCallback, float minWidth)
>>>>>>> Stashed changes
        {
            m_ItemProvider = itemProvider;
            m_ModifyItemUI = modifyItemUi;
            m_ItemClickedCallback = itemClickedCallback;
<<<<<<< Updated upstream
            m_ItemHoveredCallback = itemHoveredCallback;
=======
>>>>>>> Stashed changes
            m_SeperatorIndices = m_ItemProvider.GetSeperatorIndices();
            selectedIndex = selectionIndex;
            m_ShowAddNewPresetItem = m_ModifyItemUI != null;
            m_MinTextWidth = minWidth;
        }

        public override Vector2 GetWindowSize()
        {
            return CalcSize();
        }

        public override void OnGUI(Rect rect)
        {
            if (s_Styles == null)
                s_Styles = new Styles();

            Event evt = Event.current;

            Rect contentRect = new Rect(0, 0, 1, CalcSize().y);
            m_ScrollPosition = GUI.BeginScrollView(rect, m_ScrollPosition, contentRect);
            {
                float curY = 0f;
                for (int i = 0; i <= maxIndex; ++i)
                {
<<<<<<< Updated upstream
                    var itemControlID = i + 1000000;
                    var fullRect = new Rect(0, curY, rect.width, LineHeight);
                    var visRect = new Rect(0, curY, 16, LineHeight);
                    var pingRect = new Rect(16, curY, 16, LineHeight);
                    var backRect = new Rect(0, curY, 32, LineHeight);
                    var arrowRect = new Rect(rect.width - 16 - 1, curY, 16, LineHeight);
                    var itemRect = new Rect(16 + 16, curY, rect.width - 16 - 16, LineHeight);
                    var addSeparator = Array.IndexOf(m_SeperatorIndices, i) >= 0;
                    var isCreate = i == maxIndex;
=======
                    int itemControlID = i + 1000000;
                    Rect fullRect = new Rect(0, curY, rect.width, LineHeight);
                    Rect visRect = new Rect(0, curY, 16, LineHeight);
                    Rect pingRect = new Rect(16, curY, 16, LineHeight);
                    Rect backRect = new Rect(0, curY, 32, LineHeight);
                    Rect itemRect = new Rect(16 + 16, curY, rect.width - 16 - 16, LineHeight);
                    bool addSeparator = Array.IndexOf(m_SeperatorIndices, i) >= 0;
>>>>>>> Stashed changes

                    // Handle event
                    switch (evt.type)
                    {
                        case EventType.Repaint:
                            bool hover = false;
                            if (m_HoverIndex == i)
                            {
                                if (fullRect.Contains(evt.mousePosition))
                                    hover = true;
                                else
                                    m_HoverIndex = -1;
                            }
<<<<<<< Updated upstream
                            var isItemVisible = IsVisible(i) || isCreate;

                            using (new GUI.BackgroundColorScope(Styles.GetItemBackgroundColor(hover, hover, hover)))
                            {
                                if (!isCreate)
                                    GUI.Label(backRect, GUIContent.none, GameObjectTreeViewGUI.GameObjectStyles.hoveredItemBackgroundStyle);
                            }
                            if ((hover || !isItemVisible) && !isCreate)
=======
                            var isItemVisible = IsVisible(i);

                            using (new GUI.BackgroundColorScope(Styles.GetItemBackgroundColor(hover, hover, hover)))
                            {
                                GUI.Label(backRect, GUIContent.none, GameObjectTreeViewGUI.GameObjectStyles.hoveredItemBackgroundStyle);
                            }
                            if (hover || !isItemVisible)
>>>>>>> Stashed changes
                            {
                                var isVisHover = visRect.Contains(evt.mousePosition);
                                var visIconState = isVisHover
                                    ? Styles.iconHovered
                                    : Styles.iconNormal;
                                var visIcon = isItemVisible ? visIconState.visible : visIconState.hidden;
                                GUI.Button(visRect, visIcon, Styles.sceneVisibilityStyle);
                            }
<<<<<<< Updated upstream
                            if (hover && !isCreate)
=======
                            if (hover)
>>>>>>> Stashed changes
                            {
                                var isPingHover = pingRect.Contains(evt.mousePosition);
                                var pingIconState = isPingHover
                                    ? Styles.iconHovered
                                    : Styles.iconNormal;
                                GUI.Button(pingRect, pingIconState.ping, Styles.sceneVisibilityStyle);
                            }

                            using (new EditorGUI.DisabledScope(!isItemVisible))
<<<<<<< Updated upstream
                            {
                                s_Styles.menuItem.Draw(isCreate ? fullRect : itemRect, GUIContent.Temp(m_ItemProvider.GetName(i)), hover, false, i == selectedIndex, false);
                            }

                            if (isCreate)
                            {
                                GUI.Button(arrowRect, s_Styles.backIcon, Styles.sceneVisibilityStyle);
                            }
                            if (addSeparator)
                            {
                                const float margin = 4f;
                                Rect seperatorRect = new Rect(fullRect.x + margin, fullRect.y + fullRect.height + SeperatorHeight * 0.5f, fullRect.width - 2 * margin, 1);
                                DrawRect(seperatorRect, (EditorGUIUtility.isProSkin) ? new Color(0.32f, 0.32f, 0.32f, 1.333f) : new Color(0.6f, 0.6f, 0.6f, 1.333f)); // dark : light
                            }
=======
                                s_Styles.menuItem.Draw(itemRect, GUIContent.Temp(m_ItemProvider.GetName(i)), hover, false, i == selectedIndex, false);
>>>>>>> Stashed changes
                            break;

                        case EventType.MouseDown:
                            if (evt.button == 0 && visRect.Contains(evt.mousePosition))
                            {
                                GUIUtility.hotControl = itemControlID;
                                if (evt.clickCount == 1)
                                {
                                    GUIUtility.hotControl = 0;
                                    ToggleVisibility(i, !evt.alt);
                                    evt.Use();
                                }
                            }
                            if (evt.button == 0 && pingRect.Contains(evt.mousePosition))
                            {
                                GUIUtility.hotControl = itemControlID;
                                if (evt.clickCount == 1)
                                {
                                    GUIUtility.hotControl = 0;
                                    PingItem(i);
                                    evt.Use();
                                }
                            }
                            if (evt.button == 0 && itemRect.Contains(evt.mousePosition) && IsVisible(i))
                            {
                                GUIUtility.hotControl = itemControlID;
                                if (evt.clickCount == 1)
                                {
                                    GUIUtility.hotControl = 0;
                                    SelectItem(i);
                                    editorWindow.Close();
                                    evt.Use();
                                }
                            }
                            break;
                        case EventType.MouseUp:
                            if (GUIUtility.hotControl == itemControlID)
                            {
                                GUIUtility.hotControl = 0;
                            }
                            break;
                        case EventType.MouseMove:
                            if (fullRect.Contains(evt.mousePosition))
                            {
                                m_HoverIndex = i;
<<<<<<< Updated upstream
                                HoverItem(itemRect, m_HoverIndex);
=======
>>>>>>> Stashed changes
                            }
                            else if (m_HoverIndex == i)
                            {
                                m_HoverIndex = -1;
                            }
                            Repaint();
                            break;
                    }

                    curY += LineHeight;
                    if (addSeparator)
<<<<<<< Updated upstream
                        curY += SeperatorHeight;
=======
                        curY += SeparatorHeight;
>>>>>>> Stashed changes
                } // end foreach item
            } GUI.EndScrollView();
        }

<<<<<<< Updated upstream
        private void SelectItem(int index)
=======
        void SelectItem(int index)
>>>>>>> Stashed changes
        {
            selectedIndex = index;
            if (m_ItemClickedCallback != null && index >= 0)
                m_ItemClickedCallback(index, m_ItemProvider.GetItem(index));
        }

<<<<<<< Updated upstream
        private void HoverItem(Rect rect, int index)
        {
            if (m_ItemHoveredCallback != null && index >= 0)
                m_ItemHoveredCallback(index, rect);
        }

        private bool IsVisible(int index)
=======
        bool IsVisible(int index)
>>>>>>> Stashed changes
        {
            var obj = m_ItemProvider.GetItem(index) as GameObject;
            if (obj != null)
                return !SceneVisibilityManager.instance.IsHidden(obj);
            return false;
        }

<<<<<<< Updated upstream
        private void ToggleVisibility(int index, bool includeDescendants)
=======
        void ToggleVisibility(int index, bool includeDescendants)
>>>>>>> Stashed changes
        {
            var obj = m_ItemProvider.GetItem(index) as GameObject;
            if (obj != null)
                SceneVisibilityManager.instance.ToggleVisibility(obj, includeDescendants);
        }

<<<<<<< Updated upstream
        private void PingItem(int index)
=======
        void PingItem(int index)
>>>>>>> Stashed changes
        {
            var obj = m_ItemProvider.GetItem(index) as UnityEngine.Object;
            if (obj != null)
                EditorGUIUtility.PingObject(obj);
        }

        protected Vector2 CalcSize()
        {
<<<<<<< Updated upstream
            float height = (maxIndex + 1) * LineHeight + m_SeperatorIndices.Length * SeperatorHeight;
=======
            float height = (maxIndex + 1) * LineHeight + m_SeperatorIndices.Length * SeparatorHeight;
>>>>>>> Stashed changes
            if (m_CachedWidth < 0)
                m_CachedWidth = Math.Max(m_MinTextWidth, CalcWidth());
            return new Vector2(m_CachedWidth, height);
        }

<<<<<<< Updated upstream
        private void ClearCachedWidth()
=======
        void ClearCachedWidth()
>>>>>>> Stashed changes
        {
            m_CachedWidth = -1f;
        }

<<<<<<< Updated upstream
        private float CalcWidth()
=======
        float CalcWidth()
>>>>>>> Stashed changes
        {
            if (s_Styles == null)
                s_Styles = new Styles();

            float maxWidth = 0;
            for (int i = 0; i < m_ItemProvider.Count(); ++i)
            {
                float w = s_Styles.menuItem.CalcSize(GUIContent.Temp(m_ItemProvider.GetName(i))).x;
                maxWidth = Mathf.Max(w, maxWidth);
            }

            const float rightMargin = 6f;
            return maxWidth + rightMargin;
        }

<<<<<<< Updated upstream
        private void DrawRect(Rect rect, Color color)
        {
            if (Event.current.type != EventType.Repaint)
                return;

            Color orgColor = GUI.color;
            GUI.color = GUI.color * color;
            GUI.DrawTexture(rect, EditorGUIUtility.whiteTexture);
            GUI.color = orgColor;
        }

        private void Repaint()
=======
        void Repaint()
>>>>>>> Stashed changes
        {
            HandleUtility.Repaint(); // repaints current guiview (needs rename)
        }
    }
}
