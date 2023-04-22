using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Sprite _diedSprite;
    [SerializeField] private Sprite _liveSprite;
    [SerializeField] private List<Image> _heart = new List<Image>();
    
    public void OnDamage(int damage, int health)
    {
        int heartNumber = health;
        for (int i = health; i > health - damage; i--)
        {
            Image last = _heart[heartNumber];
            last.sprite = _diedSprite;
            heartNumber--;
            Debug.Log(last);
        }
    }

    public void OnHealth(int count, int health)
    {
        int heartNumber = health;
        for (int i = health; i < health + count; i++)
        {
            Image last = _heart[heartNumber - 1];
            last.sprite = _liveSprite;
            heartNumber++;
            Debug.Log(last);
        }
    }
}
