using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
   [Header("Set in Inspector")]
   public GameObject applePreefab; // Шаблон для яблука
   public float speed = 1f; // швидкість переміщення для яблуні
   public float leftAndRightEdge = 10f; // ліва і права мережа екрану
   public float chanceToChangeDirections = 0.1f; //  Імовірність зміни напрямку
   public float secondsBetweenAppleDrops = 1f; // чвстота скиданння якблук


   // Start is called before the first frame update
   void Start()
   {
      Invoke("DropApple", 2f);

   }

   void DropApple()
   {
      GameObject apple = Instantiate<GameObject>(applePreefab);
      apple.transform.position = transform.position;
      Invoke("DropApple", secondsBetweenAppleDrops);
   }

   // Update is called once per frame
   void Update()
   {
      // Отримуэмо поточну позицію
      Vector3 pos = transform.position;
      pos.x += speed * Time.deltaTime;
      transform.position = pos;

      if (pos.x < -leftAndRightEdge)
      {
         speed = Mathf.Abs(speed);
      }
      else if (pos.x > leftAndRightEdge)
      {
         speed = -Mathf.Abs(speed);
      }
   }

   private void FixedUpdate()
   {
      if (Random.value < chanceToChangeDirections)
      {
         speed *= -1;
      }
   }
}
