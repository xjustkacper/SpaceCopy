using UnityEngine;
using UnityEngine.U2D;
using UnityEditor;

namespace UnityEditor.U2D
{
    static internal class MenuItems
    {
<<<<<<< Updated upstream
        enum SpriteAssetMenuPriority : int
        {
            Triangle = 1,
            Square,
            Circle,
            Capsule,
            IsometricDiamond,
            HexagonFlatTop,
            HexagonPointTop,
            Sliced9
        }

        enum SpriteAtlasAssetMenuPriority : int
        {
            SpriteAtlas = SpriteAssetMenuPriority.Triangle + 11
        }

        enum SpriteGameObjectMenuPriority : int
        {
            Triangle = 1,
            Square,
            Circle,
            Capsule,
            IsometricDiamond,
            HexagonFlatTop,
            HexagonPointTop,
            Sliced9
        }

        enum PhysicsGameObjectMenuPriority : int
        {
            StaticSprite = 2,
            DynamicSprite
        }

        enum SpriteMaskGameObjectMenuPriority : int
        {
            SpriteMask = 6
        }

        [MenuItem("Assets/Create/2D/Sprites/Triangle", priority = (int)SpriteAssetMenuPriority.Triangle)]
=======
        const int k_SpriteAssetMenuPriority = 1;
        const int k_SpriteAtlasAssetMenuPriority = k_SpriteAssetMenuPriority + 11;

        const int k_SpriteGameObjectMenuPriority = 1;
        const int k_PhysicsGameObjectMenuPriority = 2;
        const int k_SpriteMaskGameObjectMenuPriority = 6;

        [MenuItem("Assets/Create/2D/Sprites/Triangle", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesTriangle(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Triangle.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Square", priority = (int)SpriteAssetMenuPriority.Square)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Square", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesSquare(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Square.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Circle", priority = (int)SpriteAssetMenuPriority.Circle)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Circle", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesCircle(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Circle.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Capsule", priority = (int)SpriteAssetMenuPriority.Capsule)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Capsule", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesCapsule(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Capsule.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Isometric Diamond", priority = (int)SpriteAssetMenuPriority.IsometricDiamond)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Isometric Diamond", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesIsometricDiamond(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/IsometricDiamond.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Hexagon Flat Top", priority = (int)SpriteAssetMenuPriority.HexagonFlatTop)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Hexagon Flat-Top", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpritesHexagonFlatTop(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonFlatTop.png");
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprites/Hexagon Point Top", priority = (int)SpriteAssetMenuPriority.HexagonPointTop)]
        static void AssetsCreateSpritesHexagonPointTop(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonPointTop.png");
        }

        [MenuItem("Assets/Create/2D/Sprites/9-Sliced", priority = (int)SpriteAssetMenuPriority.Sliced9)]
=======
        [MenuItem("Assets/Create/2D/Sprites/Hexagon Pointed-Top", priority = k_SpriteAssetMenuPriority)]
        static void AssetsCreateSpritesHexagonPointedTop(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonPointedTop.png");
        }

        [MenuItem("Assets/Create/2D/Sprites/9-Sliced", priority = k_SpriteAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSprites9Sliced(MenuCommand menuCommand)
        {
            ItemCreationUtility.CreateAssetObjectFromTemplate<Texture2D>("Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/9Sliced.png");
        }

        internal class DoCreateSpriteAtlas : ProjectWindowCallback.EndNameEditAction
        {
            public int sides;
            public override void Action(int instanceId, string pathName, string resourceFile)
            {
                var spriteAtlasAsset = new SpriteAtlasAsset();

                UnityEditorInternal.InternalEditorUtility.SaveToSerializedFileAndForget(new Object[] { spriteAtlasAsset }, pathName, true);
                AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
            }
        }

        static private void CreateSpriteAtlas()
        {
            var icon = EditorGUIUtility.IconContent<SpriteAtlasAsset>().image as Texture2D;
            DoCreateSpriteAtlas action = ScriptableObject.CreateInstance<DoCreateSpriteAtlas>();
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, action, "New Sprite Atlas.spriteatlasv2", icon, null);
        }

<<<<<<< Updated upstream
        [MenuItem("Assets/Create/2D/Sprite Atlas", priority = (int)SpriteAtlasAssetMenuPriority.SpriteAtlas)]
=======
        [MenuItem("Assets/Create/2D/Sprite Atlas", priority = k_SpriteAtlasAssetMenuPriority)]
>>>>>>> Stashed changes
        static void AssetsCreateSpriteAtlas(MenuCommand menuCommand)
        {
            if (EditorSettings.spritePackerMode == SpritePackerMode.SpriteAtlasV2 || EditorSettings.spritePackerMode == SpritePackerMode.SpriteAtlasV2Build)
                CreateSpriteAtlas();
            else
                ItemCreationUtility.CreateAssetObject<SpriteAtlas>("New Sprite Atlas.spriteatlas");
        }

        static GameObject CreateSpriteRendererGameObject(string name,  string spritePath, MenuCommand menuCommand)
        {
            var go = ItemCreationUtility.CreateGameObject(name, menuCommand, new[] {typeof(SpriteRenderer)});
            var sr = go.GetComponent<SpriteRenderer>();
            sr.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(spritePath);
            return go;
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Triangle", priority = (int)SpriteAssetMenuPriority.Triangle)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Triangle", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpritesTriangle(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Triangle", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Triangle.png", menuCommand);
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Square", priority = (int)SpriteAssetMenuPriority.Square)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Square", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpritesSquare(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Square", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Square.png", menuCommand);
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Circle", priority = (int)SpriteAssetMenuPriority.Circle)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Circle", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpritesCircle(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Circle", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Circle.png", menuCommand);
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Capsule", priority = (int)SpriteAssetMenuPriority.Capsule)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Capsule", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpritesCapsule(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Capsule", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Capsule.png", menuCommand);
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Isometric Diamond", priority = (int)SpriteAssetMenuPriority.IsometricDiamond)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Isometric Diamond", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpritesIsometricDiamond(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Isometric Diamond", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/IsometricDiamond.png", menuCommand);
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprites/Hexagon Flat Top", priority = (int)SpriteAssetMenuPriority.HexagonFlatTop)]
        static void GameObjectCreateSpritesHexagonFlatTop(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Hexagon Flat Top", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonFlatTop.png", menuCommand);
        }

        [MenuItem("GameObject/2D Object/Sprites/Hexagon Point Top", priority = (int)SpriteAssetMenuPriority.HexagonPointTop)]
        static void GameObjectCreateSpritesHexagonPointedTop(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Hexagon Point Top", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonPointTop.png", menuCommand);
        }

        [MenuItem("GameObject/2D Object/Sprites/9-Sliced", priority = (int)SpriteAssetMenuPriority.Sliced9)]
=======
        [MenuItem("GameObject/2D Object/Sprites/Hexagon Flat-Top", priority = k_SpriteGameObjectMenuPriority)]
        static void GameObjectCreateSpritesHexagonFlatTop(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Hexagon Flat-Top", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonFlatTop.png", menuCommand);
        }

        [MenuItem("GameObject/2D Object/Sprites/Hexagon Pointed-Top", priority = k_SpriteGameObjectMenuPriority)]
        static void GameObjectCreateSpritesHexagonPointedTop(MenuCommand menuCommand)
        {
            CreateSpriteRendererGameObject("Hexagon Pointed-Top", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/HexagonPointedTop.png", menuCommand);
        }

        [MenuItem("GameObject/2D Object/Sprites/9-Sliced", priority = k_SpriteGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSprites9Sliced(MenuCommand menuCommand)
        {
            var go = CreateSpriteRendererGameObject("9-Sliced", "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/9Sliced.png", menuCommand);
            var sr = go.GetComponent<SpriteRenderer>();
            if (sr.drawMode == SpriteDrawMode.Simple)
            {
                sr.drawMode = SpriteDrawMode.Tiled;
                sr.tileMode = SpriteTileMode.Continuous;
            }
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Physics/Static Sprite", priority = (int)PhysicsGameObjectMenuPriority.StaticSprite)]
=======
        [MenuItem("GameObject/2D Object/Physics/Static Sprite", priority = k_PhysicsGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreatePhysicsStaticSprite(MenuCommand menuCommand)
        {
            var go = ItemCreationUtility.CreateGameObject("Static Sprite", menuCommand, new[] {typeof(SpriteRenderer), typeof(BoxCollider2D), typeof(Rigidbody2D)});
            var sr = go.GetComponent<SpriteRenderer>();
            if (sr.sprite == null)
                sr.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(
                    "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Square.png");
            var rigidBody = go.GetComponent<Rigidbody2D>();
            rigidBody.bodyType = RigidbodyType2D.Static;
            var boxCollider2D = go.GetComponent<BoxCollider2D>();
            boxCollider2D.size = sr.sprite.rect.size / sr.sprite.pixelsPerUnit;
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Physics/Dynamic Sprite", priority = (int)PhysicsGameObjectMenuPriority.DynamicSprite)]
=======
        [MenuItem("GameObject/2D Object/Physics/Dynamic Sprite", priority = k_PhysicsGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreatePhysicsDynamicSprite(MenuCommand menuCommand)
        {
            var go = ItemCreationUtility.CreateGameObject("Dynamic Sprite", menuCommand, new[] {typeof(SpriteRenderer), typeof(CircleCollider2D), typeof(Rigidbody2D)});
            var sr = go.GetComponent<SpriteRenderer>();
            if (sr.sprite == null)
                sr.sprite = AssetDatabase.LoadAssetAtPath<Sprite>(
                    "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/v2/Circle.png");
            var rigidBody = go.GetComponent<Rigidbody2D>();
            rigidBody.bodyType = RigidbodyType2D.Dynamic;
        }

<<<<<<< Updated upstream
        [MenuItem("GameObject/2D Object/Sprite Mask", priority = (int)SpriteMaskGameObjectMenuPriority.SpriteMask)]
=======
        [MenuItem("GameObject/2D Object/Sprite Mask", priority = k_SpriteMaskGameObjectMenuPriority)]
>>>>>>> Stashed changes
        static void GameObjectCreateSpriteMask(MenuCommand menuCommand)
        {
            var go = ItemCreationUtility.CreateGameObject("Sprite Mask", menuCommand, new[] {typeof(SpriteMask)});
            go.GetComponent<SpriteMask>().sprite = AssetDatabase.LoadAssetAtPath<Sprite>(
                "Packages/com.unity.2d.sprite/Editor/ObjectMenuCreation/DefaultAssets/Textures/CircleMask.png");
        }
    }
}
