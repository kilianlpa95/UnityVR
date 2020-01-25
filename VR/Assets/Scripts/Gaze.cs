using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{
    public Image gaze;
    public float totalTime = 1;
    bool gvrStatus;
    float gvrTimer;
    private bool opening;
    private bool grabed;
    private bool throwed;
    private int level;
    private int puzzle;
    private int puzzleHard;
    public GameObject tuto1;
    public GameObject tuto2;
    public GameObject tuto3;
    public GameObject levelPassed2;
    public GameObject levelReturn2;
    public GameObject levelPassed3;
    public GameObject levelReturn3;

    public int distanceOfRay = 50;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        opening = false;
        grabed = false;
        level = 0;
        puzzle = 0;
        puzzleHard = 0;
        throwed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            gaze.fillAmount = gvrTimer/totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if(Physics.Raycast(ray, out hit, distanceOfRay))
        {
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("NorthDoor") && !opening && level == 0)
            {
                opening = !opening;
                hit.transform.gameObject.GetComponent<OpenDoor>().OpenNorth();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("SouthDoor") && !opening && level == 1)
            {
                opening = !opening;
                hit.transform.gameObject.GetComponent<OpenDoor>().OpenSouth();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("EastDoor") && !opening && level == 2)
            {
                opening = !opening;
                hit.transform.gameObject.GetComponent<OpenDoor>().OpenEast();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("WestDoor") && !opening && level == 3)
            {
                opening = !opening;
                hit.transform.gameObject.GetComponent<OpenDoor>().OpenWest();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("Exit"))
            {
                Application.Quit();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("Return"))
            {
                opening = false;
                hit.transform.gameObject.GetComponent<TP>().Teleport();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("NextLevel"))
            {
                opening = false;
                level++;
                hit.transform.gameObject.GetComponent<TP>().Teleport();
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("BowlingBall") && !grabed && !throwed)
            {
                hit.transform.gameObject.GetComponent<PlayerGrab>().GrabBowlingBall();
                grabed = !grabed;
                throwed = !throwed;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("Bowl") && grabed)
            {
                hit.transform.gameObject.GetComponent<PlayerGrab>().ThrowBowlingBall();
                grabed = !grabed;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("piece1") && puzzle == 0)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<Puzzle>().PutPiece();
                tuto1.transform.gameObject.SetActive(false);
                tuto2.transform.gameObject.SetActive(true);
                puzzle++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("piece2") && puzzle == 1)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<Puzzle>().PutPiece();
                tuto2.transform.gameObject.SetActive(false);
                tuto3.transform.gameObject.SetActive(true);
                puzzle++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("piece3") && puzzle == 2)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<Puzzle>().PutPiece();
                tuto3.transform.gameObject.SetActive(false);
                puzzle++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("piece4") && puzzle == 3)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<Puzzle>().PutPiece();
                levelPassed2.transform.gameObject.SetActive(true);
                levelReturn2.transform.gameObject.SetActive(false);
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space1") && puzzleHard == 0)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space2") && puzzleHard == 1)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space3") && puzzleHard == 2)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space4") && puzzleHard == 3)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space5") && puzzleHard == 4)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space6") && puzzleHard == 5)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space7") && puzzleHard == 6)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space8") && puzzleHard == 7)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space9") && puzzleHard == 8)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space10") && puzzleHard == 9)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space11") && puzzleHard == 10)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space12") && puzzleHard == 11)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space13") && puzzleHard == 12)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space14") && puzzleHard == 13)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space15") && puzzleHard == 14)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space16") && puzzleHard == 15)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space17") && puzzleHard == 16)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space18") && puzzleHard == 17)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space19") && puzzleHard == 18)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space20") && puzzleHard == 19)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space21") && puzzleHard == 20)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space22") && puzzleHard == 21)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space23") && puzzleHard == 22)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space24") && puzzleHard == 23)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                puzzleHard++;
            }
            if (gaze.fillAmount == 1 && hit.transform.CompareTag("space25") && puzzleHard == 24)
            {
                GVROff();
                hit.transform.gameObject.GetComponent<PuzzleHard>().PutPiece();
                levelPassed3.transform.gameObject.SetActive(true);
                levelReturn3.transform.gameObject.SetActive(false);
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        gaze.fillAmount = 0;
    }
}
