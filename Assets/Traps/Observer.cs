using UnityEngine;
using Trap;

public class Observer : MonoBehaviour
{
    private void OnEnable()
    {
        Trap.Trap.OnHit += FireCollision;
    }

    private void FireCollision()
    {
       Debug.Log("ТУТ ДОБАВЛЯЕМ ИЛИ УБИРАЕМ СЕРДЕЧКИ");
    }
}
