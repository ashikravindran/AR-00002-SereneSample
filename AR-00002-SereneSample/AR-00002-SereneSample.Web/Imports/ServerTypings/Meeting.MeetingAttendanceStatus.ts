namespace AR_00002_SereneSample.Meeting {
    export enum MeetingAttendanceStatus {
        NotSet = 0,
        Attended = 1,
        Absent = 2,
        AbsentWithPermission = 3
    }
    Serenity.Decorators.registerEnum(MeetingAttendanceStatus, 'Meeting.MeetingAttendanceStatus');
}

