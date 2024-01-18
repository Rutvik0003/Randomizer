using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scripts : MonoBehaviour
{
    public TMP_InputField input;
    public int Num;
    [SerializeField] int RandomNum;
    public TextMeshProUGUI Hint;
    string[] Hints =
    {
    "I'm nothing at the start, but add me to any number, and It remain unchanged. What am I?",
    "I'm the loneliest prime, standing tall and proud. What number am I?",
    "I'm the only even prime, can you find me within the first ten?",
    "Count on me, I'm the number that comes after two. What am I?",
    "I'm the square of the smallest even number. What number am I?",
    "I'm halfway to ten, and also the number of fingers on a hand. Who am I?",
    "I'm the sum of the first three natural numbers. What number represents me?",
    "Subtract one from eight, and you'll find me. What's the number?",
    "I'm the first cube, can you guess what number I am?",
    "I'm the product of three times three. What's my numerical identity?",
    "I'm a decade old, and a score in bowling. Who am I?",
    "I'm one more than ten, and two less than fourteen. What number is this?",
    "I'm the number of months in a year. What number am I?",
    "I'm unlucky for some, but a prime for others. Who am I?",
    "I'm a dozen plus two, can you name this numerical clue?",
    "I'm three times five, can you guess my numeric side?",
    "I'm the square of four, who am I for sure?",
    "I'm one less than eighteen, can you guess my number scene?",
    "I'm one less than eighteen, a prime in the teens. What number am I?",
    "Subtract one from twenty, and you've got me plenty. What number am I?",
    "I am the sum of ten and ten, a numerical den. What am I?",
    "I'm the product of seven and three. What number am I?",
    "I'm two times eleven, what's my numeric heaven?",
    "I'm prime, greater than twenty, can you count me plenty?",
    "I'm twice a dozen, a day less one, a number that's often overlooked. What am I?",
    "I'm the square root of 625, what number is this alive? ",
    "I'm two times thirteen, can you guess my number scene?",
    "I'm a cube, not a square, three cubed, a numerical affair. What number am I?",
    "I'm four sevens together, can you guess my number tether?",
    "I'm the last prime before thirty, can you guess me neatly?",
    "I'm the twice of the sum of the first five natural numbers, who am I under the numerals?",
    "I'm a prime number in the thirties, can you identify me with ease?",
    "I'm two to the power of five, can you name me and thrive?",
    "I'm divisible by both 3 and 11, a unique combination in mathematical heaven. What number am I?",
    "I'm two times seventeen, can you guess my number gleaned?",
    "I'm divisible by both five and seven, what number am I given?",
    "I'm a perfect square, six squared to be aware. What number am I here?",
    "I'm prime, greater than thirty five, can you guess me neatly?",
    "I'm two times nineteen, can you name me with your mind keen?",
    "I'm divisible by thirteen and three, what number am I to be?",
    "I'm the product of four and ten, who am I again?",
    "I'm prime, in the forties, can you name me with your witties?",
    "I'm the answer to life, the universe, and everything, as famously said. What number am I led?",
    "I'm prime, greater than forty, can you identify me aplenty?",
    "I'm two times twenty-two, can you guess my number through?",
    "I'm the sum of the first nine natural numbers, what number am I under the numerals?",
    "I'm two times twenty-three, can you name me effortlessly?",
    "I'm prime, less than fifty, who am I? Can you be nifty?",
    "I'm the product of four and twelve, what number am I to delve?",
    "I'm a square less than fifty, can you identify me swiftly?",
    "I'm halfway to a hundred, can you name me undaunted?"
    };
    public TextMeshProUGUI HintText;

    private void Awake()
    {
        GenerateNum();
        HintText.text = Hints[RandomNum];
    }

    void GenerateNum()
    {
        RandomNum = Random.Range(0, 51);
    }

    public  void GetInput()
    {
        if (int.TryParse(input.text, out Num) && Num > RandomNum)
        {
            Hint.text = "Guess Smaller Ones";


        }
        else if (int.TryParse(input.text, out Num) && Num < RandomNum)
        {
            Hint.text = "Guess Bigger Ones";


        }
        else if (int.TryParse(input.text, out Num) && Num == RandomNum)
        {
            Debug.Log("Congratulation");
            SceneManager.LoadScene(2);
           
        }

        input.text = "";
    }
    
       
    

    
}
