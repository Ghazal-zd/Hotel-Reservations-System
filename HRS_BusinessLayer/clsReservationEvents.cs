using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsReservationEvents
    {
        public class ReservationCreatedEventArgs : EventArgs
        {
            public int ReservationID { get; }
            public int RoomID { get; }
            public ReservationCreatedEventArgs(int reservationID, int roomID)
            {
                this.ReservationID = reservationID;
                this.RoomID = roomID;
            }
        }
        public static event EventHandler<ReservationCreatedEventArgs> ReservationCreated;
        public static void OnReservationCreated(int reservationID, int roomID)
        {
            ReservationCreated?.Invoke(null, new ReservationCreatedEventArgs(reservationID, roomID));
        }

        public class ReservationUpComingEventArgs : EventArgs
        {
            public int ReservationID { get; }

            public ReservationUpComingEventArgs(int reservationID)
            {
                this.ReservationID = reservationID;
            }
        }
        public static event EventHandler<ReservationUpComingEventArgs> ReservationApproachingCheckIn;
        public static event EventHandler<ReservationUpComingEventArgs> ReservationApproachingCheckOut;
        public static void OnReservationApproachingCheckIn(int reservationID)
        {
            ReservationApproachingCheckIn?.Invoke(null, new ReservationUpComingEventArgs(reservationID));
        }
        public static void OnReservationApproachingCheckOut(int reservationID)
        {
            ReservationApproachingCheckOut?.Invoke(null, new ReservationUpComingEventArgs(reservationID));
        }

        public class RoomOccupiedEventArgs : EventArgs
        {
            public int RoomID { get; }
            public DateTime CreatedAt = DateTime.Now;
            public RoomOccupiedEventArgs(int roomID)
            {
                RoomID = roomID;
            }
        }
        public static event EventHandler<RoomOccupiedEventArgs> RoomOccupied;
        public static void OnRoomOccupied(int roomID)
        {
            RoomOccupied?.Invoke(null, new RoomOccupiedEventArgs(roomID));
        }

    }
}
