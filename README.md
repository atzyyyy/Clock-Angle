# Clock Angle Problem
**By: Fourthram Kaimo**


Given a specific time on a 12-hour analog clock, determine the angle (in degrees) between the hour hand and the minute hand. 

*The input is limited to 12-hour clock format.* 

---

## Solution

1. Calculate the change of angle in degrees per minute for the hour hand, which will be **360° / 720 minutes (12 hours) = 0.5° per minute**.
2. Calculate the change of angle in degrees per minute for the minute hand, which will be **360° / 60 minutes = 6° per minute**.
3. Formulate a formula that will calculate the angle of the hour hand relative to 12:00. I also take in consideration that there will be an additional degrees since the hour hand moves slightly based on the minutes passed.
    > 0.5 * (hours * 60 + minutes)
 
    *The hours is converted into minutes by multiplying it to 60 and then added the minute value to get the total number of minutes. Finally, multiplied to 0.5 to get the degrees per minute.*


4. Get the minute hand angle by multiplying 6° to the number of total minutes relative to 12:00. 
    > 6 * minutes


5. The difference between the hour hand angle and the minute hand angle will then be the inner angle between the hour hand and minute hand.

