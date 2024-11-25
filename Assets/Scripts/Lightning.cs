using UnityEngine;

// code from ChatGPT

public class Lightning: MonoBehaviour {
    public ParticleSystem particleSystem;
    public float minEmissionTime = 5f;
    public float maxEmissionTime = 10f;

    private void Start() {
        StartCoroutine(EmitParticlesRandomly());
    }

    private System.Collections.IEnumerator EmitParticlesRandomly() {
        while (true) {
            float randomDelay = Random.Range(minEmissionTime, maxEmissionTime);
            yield return new WaitForSeconds(randomDelay);

            particleSystem.Emit(10);
        }
    }
}