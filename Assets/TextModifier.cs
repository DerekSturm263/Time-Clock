using UnityEngine;

public class TextModifier : MonoBehaviour
{
    public TMPro.TMP_InputField inputField;

    public void AppendText(string text)
    {
        if (inputField.text.Length >= inputField.characterLimit)
            return;

        inputField.text += text;
    }

    public void RemoveTextFromEnd(int count)
    {
        inputField.text = inputField.text[..^count];
    }

    public void SubmitText()
    {
        inputField.onEndEdit.Invoke(inputField.text);
    }
}
