namespace DormRoomRental.Models;

public class Dorm
{
    private readonly Student?[] _students;

    public int Capacity
    {
        get { return _students.Length; }
    }

    public Dorm(int capacity)
    {
        _students = new Student?[capacity];
    }

    public bool IsValidRoom(int roomNumber)
    {
        return roomNumber >= 1 && roomNumber <= Capacity;
    }

    public bool IsRoomOccupied(int roomNumber)
    {
        return _students[roomNumber - 1] != null;
    }

    public bool RentRoom(int roomNumber, Student student)
    {
        if (!IsValidRoom(roomNumber) || IsRoomOccupied(roomNumber))
            return false;

        _students[roomNumber - 1] = student;
        return true;
    }

    public Student? GetStudent(int roomNumber)
    {
        return _students[roomNumber - 1];
    }

    public string GetAvailableRooms()
    {
        var availableRooms = "";

        for (int roomNumber = 1; roomNumber <= Capacity; roomNumber++)
        {
            if (IsRoomOccupied(roomNumber))
                continue;

            availableRooms += $" {roomNumber}";
        }

        return availableRooms;
    }
}
