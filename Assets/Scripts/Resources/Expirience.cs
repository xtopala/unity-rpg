using UnityEngine;

namespace RPG.Resources
{
    public class Expirience : MonoBehaviour
    {
        [SerializeField] float experiencePoints = 0;

        public void GainExpirience(float experience)
        {
            experiencePoints += experience;
        }
    }
}