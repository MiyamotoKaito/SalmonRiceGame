using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NovelGame
{
    public class ImageManager : MonoBehaviour
    {
        [SerializeField] Sprite[] _backgrounds;
        [SerializeField] Sprite[] _events;
        [SerializeField] GameObject _backgroundObject;
        [SerializeField] GameObject _eventObject;
        [SerializeField] GameObject _imagePrefab;

        Dictionary<string, GameObject> _textToSpriteObject;

        void Awake()
        {
            _textToSpriteObject = new Dictionary<string, GameObject>();
        }

        // ‰æ‘œ‚ð”z’u‚·‚é
        public void PutImage(string imageName, string parentObjectName)
        {
            Sprite image = GetSprite(imageName);
            GameObject parentObject = GetParentObject(parentObjectName);

            if (image == null || parentObject == null) return;

            Vector2 position = new Vector2(0, 0);
            Quaternion rotation = Quaternion.identity;
            Transform parent = parentObject.transform;
            GameObject item = Instantiate(_imagePrefab, position, rotation, parent);
            item.GetComponent<Image>().sprite = image;
            _textToSpriteObject.Add(imageName, item);
        }

        Sprite GetSprite(string imageName)
        {
            if (imageName.StartsWith("background"))
            {
                int index = int.Parse(imageName.Replace("background", "")) - 1;
                return (index >= 0 && index < _backgrounds.Length) ? _backgrounds[index] : null;
            }
            else if (imageName.StartsWith("eventCG"))
            {
                int index = int.Parse(imageName.Replace("eventCG", "")) - 1;
                return (index >= 0 && index < _events.Length) ? _events[index] : null;
            }
            return null;
        }

        GameObject GetParentObject(string parentObjectName)
        {
            switch (parentObjectName)
            {
                case "backgroundObject":
                    return _backgroundObject;
                case "eventObject":
                    return _eventObject;
                default:
                    return null;
            }
        }
    }
}