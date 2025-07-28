using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace NovelGame
{
    public class ImageManager : MonoBehaviour
    {
        [SerializeField] Sprite _backGrond1;
        [SerializeField] GameObject _backGroundObject;
        [SerializeField] GameObject _imagePrefab;

        //テキストファイルから、文字列でSpriteやGameObjectを扱えるようにする
        Dictionary<string, Sprite> _textToSprites;
        Dictionary<string, GameObject> _textToParentObject;
        //操作したいPrefabを指定できるようにするための辞書
        Dictionary<string, GameObject> _textToSpriteObject;
        private void Awake()
        {
            _textToSprites = new Dictionary<string, Sprite>();
            _textToSprites.Add("BackGround1",_backGrond1);

            _textToParentObject = new Dictionary<string, GameObject>();
            _textToParentObject.Add("BackGroundObject", _backGroundObject);

            _textToSpriteObject = new Dictionary<string, GameObject>();
        }
        /// <summary>
        /// 画像の配置
        /// </summary>
        public void PutImage(string imageName, string parentObjectName)
        {
            Sprite image = _textToSprites[imageName];
            GameObject parentObject = _textToParentObject[parentObjectName];

            Vector2 pos = new Vector2 (0,0);
            Quaternion rot = Quaternion.identity;
            Transform parent = parentObject.transform;
            GameObject item = Instantiate(_imagePrefab, pos, rot, parent);
            item.GetComponent<Image>().sprite = image;

            _textToSpriteObject.Add(imageName, item);
        }
    }

}
