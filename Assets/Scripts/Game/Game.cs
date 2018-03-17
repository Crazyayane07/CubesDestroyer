using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    int enemiesToCreate = InputFieldControl.getEnemiesNumber();
    GameObject enemy;
    public static int score { get; set; }
    Color[] colorList = new Color[]{Color.red, Color.black, Color.blue, Color.cyan, Color.gray,
                         Color.green, Color.grey, Color.magenta,
                         Color.white, Color.yellow };
    public static float timer;
    public static float timeScore;

    void Start()
    {
        score = 0;
        timer = 0;
        int enemies = 0;

        while(enemies < enemiesToCreate)
        {
            int id = enemies;
            CreateEnemy(id);
            enemies++;
        }
    }
    void Update()
    {
        if(score == enemiesToCreate)
        {
            timeScore = timer;
            Die();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void CreateEnemy(int id)
    {
        enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);

        float size = Random.Range(0.5f, 3f);
        enemy.transform.localScale = new Vector3(size, size, size);

        enemy.name = id.ToString();
        enemy.AddComponent<Enemy>();

        int colorIndex = (int)Random.Range(0f, colorList.Length);
        Color randColor = colorList[colorIndex];
        enemy.GetComponent<Renderer>().material.color = randColor;

        float x = Random.Range(-8.0f, 8.0f);
        Debug.Log("x = " + x.ToString());

        float y = Random.Range(-4.0f, 4.0f);
        Debug.Log("y = " + y.ToString());

        Vector2 location = new Vector2(x, y);

        float rotation = Random.Range(-100, 20f);
        Instantiate(enemy, location, Quaternion.identity).transform.Rotate(Vector3.forward * rotation);

        Destroy(enemy);
    }

    private void Die()
    {
        SceneManager.LoadScene("EndGame");
    }
}
