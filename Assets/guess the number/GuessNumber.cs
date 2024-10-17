using TMPro;
using UnityEngine;

public class GuessNumber : MonoBehaviour
{
    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        messageText.text = "https://www.youtube.com/watch?v=NRTCr8SODJE";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {
            messageText.text = "T'inquiètes ça arrive même aux meilleurs de se tromper ^^";
            numberInput.text = "";
            return;
        }
        if(int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)
            {
                messageText.text = "LETSSS GOOOOO t'as trouvé bg";
            }
            else if (playerNumber> randomNumber)
            {
                messageText.text = "calmos il pas si grand le nombre";
            }
            else if(playerNumber<randomNumber)
            {
                messageText.text = "un peu plus quand même!";
            }
            //Si playerNumber est égal a randomnumber
                //Victoire (changer le message, reset le champ du texte)
            //SI le player Numberest supérieur a randomNumber
                //Annoncer moins
            //Si player number est inférieur a randomNumber
                //Annoncer plus
        }
        else
        {
            messageText.text = "T'inquiètes ça arrive même aux meilleurs de se tromper ^^";
            numberInput.text = "";
            return;
        }
        numberInput.text = "";

    }
    public void Reset()
    {
        messageText.text = "https://www.youtube.com/watch?v=NRTCr8SODJE";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
    }

}