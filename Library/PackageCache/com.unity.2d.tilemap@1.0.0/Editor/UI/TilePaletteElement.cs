using System;
using UnityEditor.ShortcutManagement;
using UnityEditor.Toolbars;
using UnityEngine.UIElements;

namespace UnityEditor.Tilemaps
{
    /// <summary>
    /// A Visual Element which handles and displays a Tile Palette Clipboard
    /// and its associated tools.
    /// </summary>
    /// <description>
    /// This Visual Element includes other Visual Elements that help with managing
    /// the Tile Palette Clipboard, which includes a popup dropdown for selecting
    /// the active Palette and a toolbar for enabling edits and showing visual aids
    /// in the Tile Palette Clipboard.
    /// </description>
    public class TilePaletteElement : VisualElement
    {
        /// <summary>
        /// Factory for TilePaletteElement.
        /// </summary>
        public class TilePaletteElementFactory : UxmlFactory<TilePaletteElement, TilePaletteElementUxmlTraits> {}
        /// <summary>
        /// UxmlTraits for TilePaletteElement.
        /// </summary>
        public class TilePaletteElementUxmlTraits : UxmlTraits {}

        private static readonly string ussClassName = "unity-tilepalette-element";
        private static readonly string toolbarUssClassName = ussClassName + "-toolbar";
        private static readonly string rightToolbarUssClassName = toolbarUssClassName + "-right";
<<<<<<< Updated upstream

        private static readonly string kTilePaletteElementHideOnPickEditorPref = "TilePaletteElementHideOnPick";

        private static readonly string k_Name = L10n.Tr("Tile Palette Element");

        private static string[] k_LeftToolbarElements = new[]
        {
            TilePaletteActivePalettePopupIcon.k_ToolbarId
            , TilePaletteActivePalettePopup.k_ToolbarId
        };

        private static string[] k_RightToolbarElements = new[] {
            TilePaletteEditToggle.k_ToolbarId
            , TilePaletteGridToggle.k_ToolbarId
            , TilePaletteGizmoToggle.k_ToolbarId
            , TilePaletteHideClipboardToggle.k_ToolbarId
        };
        private static bool[] k_TilePaletteWindowActiveRightToolbar = new[] { true, true, true, false };
        private static bool[] k_TilePaletteOverlayActiveRightToolbar = new[] { true, true, true, true };

        private VisualElement m_ToolbarElement;
        private TilePaletteClipboardElement m_ClipboardElement;
        private TilePaletteEditToggle m_EditToggle;
        private TilePaletteGridToggle m_GridToggle;
        private TilePaletteGizmoToggle m_GizmoToggle;
        private TilePaletteHideClipboardToggle m_HideToggle;
        private VisualElement m_RightToolbar;

        private event Action onBrushPickedInternal;
=======
        private static readonly string buttonStripClassName = "unity-editor-toolbar__button-strip";
        private static readonly string stripElementClassName = buttonStripClassName + "-element";
        private static readonly string leftStripElementClassName = stripElementClassName + "--left";
        private static readonly string middleStripElementClassName = stripElementClassName + "--middle";
        private static readonly string rightStripElementClassName = stripElementClassName + "--right";
        private static readonly string aloneStripElementClassName = stripElementClassName + "--alone";

        private static readonly string k_Name = L10n.Tr("Tile Palette Element");

        private TilePaletteClipboardElement m_ClipboardElement;
        private TilePaletteEditToggle m_EditToggle;
>>>>>>> Stashed changes

        /// <summary>
        /// Whether the clipboard is unlocked for editing.
        /// </summary>
        public bool clipboardUnlocked
        {
            get => m_ClipboardElement.clipboardUnlocked;
            set
            {
                m_ClipboardElement.clipboardUnlocked = value;
                m_EditToggle.SetValueWithoutNotify(value);
            }
        }

<<<<<<< Updated upstream
        /// <summary>
        /// Whether the clipboard is hidden when the Pick EditorTool is activated on it.
        /// </summary>
        public bool hideOnPick
        {
            get => EditorPrefs.GetBool(kTilePaletteElementHideOnPickEditorPref, true);
            set
            {
                EditorPrefs.SetBool(kTilePaletteElementHideOnPickEditorPref, value);
                m_HideToggle.SetValueWithoutNotify(value);
            }
        }

        /// <summary>
        /// Callback when the active Brush does a Pick on the Clipboard.
        /// </summary>
        public event Action onBrushPicked
        {
            add
            {
                onBrushPickedInternal += value;
                SetupRightToolbar();
            }
            remove
            {
                onBrushPickedInternal -= value;
                SetupRightToolbar();
            }
        }

=======
>>>>>>> Stashed changes
        internal GridPaintPaletteClipboard clipboardView => m_ClipboardElement.clipboardView;

        /// <summary>
        /// Initializes and returns an instance of TilePaletteElement.
        /// </summary>
        public TilePaletteElement()
        {
            AddToClassList(ussClassName);

            name = k_Name;
            TilePaletteOverlayUtility.SetStyleSheet(this);

<<<<<<< Updated upstream
            m_ToolbarElement = new VisualElement();
            m_ToolbarElement.AddToClassList(toolbarUssClassName);
            Add(m_ToolbarElement);

            m_ClipboardElement = new TilePaletteClipboardElement();
            m_ClipboardElement.onBrushPicked += OnBrushPicked;
            Add(m_ClipboardElement);

            var leftToolbar = EditorToolbar.CreateOverlay(k_LeftToolbarElements);
            m_ToolbarElement.Add(leftToolbar);

            var rightToolbarElement = new VisualElement();
            rightToolbarElement.AddToClassList(rightToolbarUssClassName);
            m_ToolbarElement.Add(rightToolbarElement);

            m_RightToolbar = EditorToolbar.CreateOverlay(k_RightToolbarElements);
            SetupRightToolbar();
            rightToolbarElement.Add(m_RightToolbar);
=======
            var toolbarElement = new VisualElement();
            toolbarElement.AddToClassList(toolbarUssClassName);
            Add(toolbarElement);

            m_ClipboardElement = new TilePaletteClipboardElement();
            Add(m_ClipboardElement);

            string[] leftToolbarElements = new[] { TilePaletteActivePalettePopupIcon.k_ToolbarId, TilePaletteActivePalettePopup.k_ToolbarId };
            var leftToolbar = EditorToolbar.CreateOverlay(leftToolbarElements);
            toolbarElement.Add(leftToolbar);

            var rightToolbarElement = new VisualElement();
            rightToolbarElement.AddToClassList(rightToolbarUssClassName);
            toolbarElement.Add(rightToolbarElement);

            string[] rightToolbarElements = new[] {
                TilePaletteEditToggle.k_ToolbarId
                , TilePaletteGridToggle.k_ToolbarId
                , TilePaletteGizmoToggle.k_ToolbarId
                , TilePaletteBrushElementToggle.k_ToolbarId
            };
            var rightToolbar = EditorToolbar.CreateOverlay(rightToolbarElements);
            SetupChildrenAsButtonStripForVisible(rightToolbar);
            rightToolbarElement.Add(rightToolbar);
>>>>>>> Stashed changes

            m_EditToggle = this.Q<TilePaletteEditToggle>();
            m_EditToggle.SetValueWithoutNotify(false);
            m_EditToggle.ToggleChanged += OnEditToggleChanged;

<<<<<<< Updated upstream
            m_GridToggle = this.Q<TilePaletteGridToggle>();
            m_GridToggle.SetValueWithoutNotify(GridPaintingState.drawGridGizmo);
            m_GridToggle.ToggleChanged += OnGridToggleChanged;

            m_GizmoToggle = this.Q<TilePaletteGizmoToggle>();
            m_GizmoToggle.SetValueWithoutNotify(GridPaintingState.drawGizmos);
            m_GizmoToggle.ToggleChanged += OnGizmoToggleChanged;

            m_HideToggle = this.Q<TilePaletteHideClipboardToggle>();
            m_HideToggle.SetValueWithoutNotify(hideOnPick);
            m_HideToggle.ToggleChanged += OnHideClipboardToggleChanged;

            RegisterCallback<AttachToPanelEvent>(OnAttachedToPanel);
            RegisterCallback<DetachFromPanelEvent>(OnDetachFromPanel);

            UpdateToggleState();
=======
            var gridToggle = this.Q<TilePaletteGridToggle>();
            gridToggle.SetValueWithoutNotify(GridPaintingState.drawGridGizmo);
            gridToggle.ToggleChanged += OnGridToggleChanged;

            var gizmoToggle = this.Q<TilePaletteGizmoToggle>();
            gizmoToggle.SetValueWithoutNotify(GridPaintingState.drawGizmos);
            gizmoToggle.ToggleChanged += OnGizmoToggleChanged;

            RegisterCallback<AttachToPanelEvent>(OnAttachedToPanel);
            RegisterCallback<DetachFromPanelEvent>(OnDetachedToPanel);
>>>>>>> Stashed changes
        }

        private void OnAttachedToPanel(AttachToPanelEvent evt)
        {
            m_ClipboardElement.clipboardUnlockedChanged += OnUnlockedChanged;
<<<<<<< Updated upstream
            GridPaintingState.palettesChanged += UpdateToggleState;
        }

        private void OnDetachFromPanel(DetachFromPanelEvent evt)
        {
            GridPaintingState.palettesChanged -= UpdateToggleState;
            m_ClipboardElement.clipboardUnlockedChanged -= OnUnlockedChanged;
        }

        private void OnBrushPicked()
        {
            if (hideOnPick)
                onBrushPickedInternal?.Invoke();
=======
        }

        private void OnDetachedToPanel(DetachFromPanelEvent evt)
        {
            m_ClipboardElement.clipboardUnlockedChanged -= OnUnlockedChanged;
        }

        private static void SetupChildrenAsButtonStripForVisible(VisualElement root)
        {
            root.AddToClassList(buttonStripClassName);

            int count = root.hierarchy.childCount;
            if (count == 1)
            {
                var element = root.hierarchy.ElementAt(0);
                bool visible = element.style.display != DisplayStyle.None && element.visible;
                element.EnableInClassList(aloneStripElementClassName, visible);
            }
            else
            {
                bool firstVisible = false;
                int lastVisible = 0;
                for (var i = 0; i < count; ++i)
                {
                    var element = root.hierarchy.ElementAt(i);

                    //Skip if element not visible
                    bool visible = element.style.display != DisplayStyle.None && element.visible;
                    element.AddToClassList(stripElementClassName);
                    if (firstVisible)
                    {
                        element.EnableInClassList(middleStripElementClassName, visible);
                    }
                    if (!firstVisible)
                    {
                        element.EnableInClassList(leftStripElementClassName, visible);
                        firstVisible = true;
                    }
                    if (visible)
                        lastVisible = i;
                }
                var lastElement = root.hierarchy.ElementAt(lastVisible);
                if (lastElement.ClassListContains(leftStripElementClassName))
                {
                    lastElement.RemoveFromClassList(leftStripElementClassName);
                    lastElement.AddToClassList(aloneStripElementClassName);
                }
                else
                {
                    lastElement.RemoveFromClassList(middleStripElementClassName);
                    lastElement.AddToClassList(rightStripElementClassName);
                }
            }
>>>>>>> Stashed changes
        }

        private void OnEditToggleChanged(bool unlock)
        {
            clipboardUnlocked = unlock;
        }

        private void OnUnlockedChanged(bool unlock)
        {
            m_EditToggle.SetValueWithoutNotify(unlock);
        }

        private void OnGridToggleChanged(bool drawGridGizmo)
        {
            GridPaintingState.drawGridGizmo = drawGridGizmo;
        }

        private void OnGizmoToggleChanged(bool drawGizmo)
        {
            GridPaintingState.drawGizmos = drawGizmo;
        }
<<<<<<< Updated upstream

        private void UpdateToggleState()
        {
            bool hasPalette = GridPaintingState.palettes != null && GridPaintingState.palettes.Count > 0;
            m_EditToggle.SetEnabled(hasPalette);
            m_GridToggle.SetEnabled(hasPalette);
            m_GizmoToggle.SetEnabled(hasPalette);
        }

        private void OnHideClipboardToggleChanged(bool hideClipboard)
        {
            hideOnPick = hideClipboard;
        }

        private void SetupRightToolbar()
        {
            TilePaletteOverlayUtility.SetupChildrenAsButtonStripForVisible(m_RightToolbar,
                onBrushPickedInternal != null ? k_TilePaletteOverlayActiveRightToolbar : k_TilePaletteWindowActiveRightToolbar);
        }
=======
>>>>>>> Stashed changes
    }

    [EditorToolbarElement(k_ToolbarId)]
    internal sealed class TilePaletteEditToggle : EditorToolbarToggle
    {
        internal const string k_ToolbarId = "Tile Palette/Tile Palette Edit";

        private static readonly string k_ToolSettingsClass = "unity-tool-settings";
        private static readonly string k_ElementClass = "unity-tilepalette-element-tilepaletteedit";

        private static readonly string k_IconPath = "Packages/com.unity.2d.tilemap/Editor/Icons/Tilemap.EditPalette.png";
        private static readonly string k_TooltipText = L10n.Tr("Toggles Tile Palette Edit");

        public Action<bool> ToggleChanged;

        public TilePaletteEditToggle()
        {
            name = "Tile Palette Edit";
            AddToClassList(k_ToolSettingsClass);
            AddToClassList(k_ElementClass);
            TilePaletteOverlayUtility.SetStyleSheet(this);

            icon = EditorGUIUtility.LoadIcon(k_IconPath);
            tooltip = k_TooltipText;
        }

        protected override void ToggleValue()
        {
            base.ToggleValue();
            ToggleChanged?.Invoke(value);
        }
    }

    [EditorToolbarElement(k_ToolbarId)]
    internal sealed class TilePaletteGridToggle : EditorToolbarToggle
    {
        internal const string k_ToolbarId = "Tile Palette/Tile Palette Grid";

        private static readonly string k_ToolSettingsClass = "unity-tool-settings";
        private static readonly string k_ElementClass = "unity-tilepalette-element-gridtoggle";

        private static readonly string k_IconPath = "Packages/com.unity.2d.tilemap/Editor/Icons/Tilemap.ShowGrid.png";
        private static readonly string k_TooltipText = L10n.Tr("Toggle visibility of the Grid in the Tile Palette");

        public Action<bool> ToggleChanged;

        public TilePaletteGridToggle()
        {
            name = "Tile Palette Grid";
            AddToClassList(k_ToolSettingsClass);
            AddToClassList(k_ElementClass);
            TilePaletteOverlayUtility.SetStyleSheet(this);

            icon = EditorGUIUtility.LoadIcon(k_IconPath);
            tooltip = k_TooltipText;
        }

        protected override void ToggleValue()
        {
            base.ToggleValue();
            ToggleChanged?.Invoke(value);
        }
    }

    [EditorToolbarElement(k_ToolbarId)]
    internal sealed class TilePaletteBrushElementToggle : EditorToolbarToggle
    {
        internal const string k_ToolbarId = "Tile Palette/Tile Palette Brush Element";

        private static readonly string k_ToolSettingsClass = "unity-tool-settings";
        private static readonly string k_ElementClass = "unity-tilepalette-element-brushelement";

        private static readonly string k_IconPath = "Packages/com.unity.2d.tilemap/Editor/Icons/Tilemap.BrushSettings.png";
        private static readonly string k_TooltipText = L10n.Tr("Toggle visibility of the Brush Inspector in the Tile Palette");

        public Action<bool> ToggleChanged;

        public TilePaletteBrushElementToggle()
        {
            name = "Tile Palette Grid";
            AddToClassList(k_ToolSettingsClass);
            AddToClassList(k_ElementClass);
            TilePaletteOverlayUtility.SetStyleSheet(this);

            icon = EditorGUIUtility.LoadIcon(k_IconPath);
            tooltip = k_TooltipText;
        }

        protected override void ToggleValue()
        {
            base.ToggleValue();
            ToggleChanged?.Invoke(value);
        }
    }

    [EditorToolbarElement(k_ToolbarId)]
    internal sealed class TilePaletteGizmoToggle : EditorToolbarToggle
    {
        internal const string k_ToolbarId = "Tile Palette/Tile Palette Gizmo";

        private static readonly string k_ToolSettingsClass = "unity-tool-settings";
        private static readonly string k_ElementClass = "unity-tilepalette-element-gizmotoggle";

        private static readonly string k_IconPath = "GizmosToggle";
        private static readonly string k_TooltipText = L10n.Tr("Toggle visibility of Gizmos in the Tile Palette");

        public Action<bool> ToggleChanged;

        public TilePaletteGizmoToggle()
        {
            name = "Tile Palette Gizmo";
            AddToClassList(k_ToolSettingsClass);
            AddToClassList(k_ElementClass);
            TilePaletteOverlayUtility.SetStyleSheet(this);

            icon = EditorGUIUtility.LoadIcon(k_IconPath);
            tooltip = k_TooltipText;
        }

        protected override void ToggleValue()
        {
            base.ToggleValue();
            ToggleChanged?.Invoke(value);
        }
    }

    [EditorToolbarElement(k_ToolbarId)]
    internal sealed class TilePaletteHideClipboardToggle : EditorToolbarToggle
    {
        internal const string k_ToolbarId = "Tile Palette/Tile Palette Hide Clipboard";

        private static readonly string k_ToolSettingsClass = "unity-tool-settings";
        private static readonly string k_ElementClass = "unity-tilepalette-element-hideclipboard";

        private static readonly string k_IconPath = "Packages/com.unity.2d.tilemap/Editor/Icons/Tilemap.ShowTilePalette.png";
        private static readonly string k_TooltipFormatText = L10n.Tr("Hides Tile Palette on Pick. ( {0} ) to show/hide Tile Palette.");
        private static readonly string k_ShortcutId = "Grid Painting/Toggle SceneView Palette";

        public Action<bool> ToggleChanged;

        public TilePaletteHideClipboardToggle()
        {
            name = "Tile Palette Hide Clipboard";
            AddToClassList(k_ToolSettingsClass);
            AddToClassList(k_ElementClass);
            TilePaletteOverlayUtility.SetStyleSheet(this);

            icon = EditorGUIUtility.LoadIcon(k_IconPath);

            RegisterCallback<AttachToPanelEvent>(OnAttachedToPanel);
            RegisterCallback<DetachFromPanelEvent>(OnDetachFromPanel);
        }

        private void OnAttachedToPanel(AttachToPanelEvent evt)
        {
            ShortcutIntegration.instance.profileManager.shortcutBindingChanged += OnShortcutBindingChanged;
            UpdateTooltip();
        }

        private void OnDetachFromPanel(DetachFromPanelEvent evt)
        {
            ShortcutIntegration.instance.profileManager.shortcutBindingChanged -= OnShortcutBindingChanged;
        }

        private void OnShortcutBindingChanged(IShortcutProfileManager arg1, Identifier arg2, ShortcutBinding arg3, ShortcutBinding arg4)
        {
            UpdateTooltip();
        }

        private void UpdateTooltip()
        {
            tooltip = String.Format(k_TooltipFormatText, ShortcutManager.instance.GetShortcutBinding(k_ShortcutId));
        }

        protected override void ToggleValue()
        {
            base.ToggleValue();
            ToggleChanged?.Invoke(value);
        }
    }
}
