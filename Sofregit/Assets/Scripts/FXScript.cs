using UnityEngine;

    public class FXScript : MonoBehaviour
    {
        public AudioSource ErrorSound;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PlayErrorSound()
        {
            ErrorSound.Play();
        }

    private void onNotAllowedActionTried()
    {
        PlayErrorSound();
    }
}
