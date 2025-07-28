using NovelGame;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisPlayText();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            GoToNextLine();
            DisPlayText();
        }
    }
    /// <summary>
    /// ���̍s�Ɉړ�
    /// </summary>
    public void GoToNextLine()
    {
        GamaManager.Instance.lineNumber++;
    }
    /// <summary>
    /// �e�L�X�g�\��
    /// </summary>
    public void DisPlayText()
    {
        string sentence = GamaManager.Instance.userManager.GetCurrentSentence();
        _mainTextObject.text = sentence;
    }
}
