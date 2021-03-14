using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimal : MonoBehaviour
{
    public static int num;
    public static bool boolean;
    public static int animalCount = 0;
    public static bool sheepTurn = false;
    public static bool pigTurn = false;
    public static bool cowTurn = false;

    // Start is called before the first frame update
    void Start()
    {
        RandomizeAnimals();
    }

    public void RandomizeAnimals()
    {
        num = Random.Range(0, 3);
        switch (num)
        {
            case 0:
                sheepTurn = true;
                Debug.Log("Sheep selected first");
                break;
            case 1:
                pigTurn = true;
                Debug.Log("Pig selected first");
                break;
            case 2:
                cowTurn = true;
                Debug.Log("Cow selected first");
                break;
            default:
                break;
        }
    }
}
