// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#calendar').fullCalendar({
    header: {
        left: 'prev,next today',
        center: 'title',
        right: 'month,agendaWeek,agendaDay,listWeek'
    },
    defaultDate: '2018-11-16',
    navLinks: true,
    eventLimit: true,
    events: [{
        title: 'Front-End Conference',
        start: '2018-11-16',
        end: '2018-11-18'
    },
    {
        title: 'Hair stylist with Mike',
        start: '2018-11-20',
        allDay: true
    },
    {
        title: 'Car mechanic',
        start: '2018-11-14T09:00:00',
        end: '2018-11-14T11:00:00'
    },
    {
        title: 'Dinner with Mike',
        start: '2018-11-21T19:00:00',
        end: '2018-11-21T22:00:00'
    },
    {
        title: 'Chillout',
        start: '2018-11-15',
        allDay: true
    },
    {
        title: 'Vacation',
        start: '2018-11-23',
        end: '2018-11-29'
    },
    ]
});
/*Add Event*/

$('#calendar').fullCalendar({
    header: {
        left: 'prev,next today',
        center: 'addEventButton',
        right: 'month,agendaWeek,agendaDay,listWeek'
    },
    defaultDate: '2018-11-16',
    navLinks: true,
    editable: true,
    eventLimit: true,
    events: [{
        title: 'Simple static event',
        start: '2018-11-16',
        description: 'Super cool event'
    },

    ],
    customButtons: {
        addEventButton: {
            text: 'Add new event',
            click: function () {
                var dateStr = prompt('Enter date in YYYY-MM-DD format');
                var date = moment(dateStr);

                if (date.isValid()) {
                    $('#calendar').fullCalendar('renderEvent', {
                        title: 'Dynamic event',
                        start: date,
                        allDay: true
                    });
                } else {
                    alert('Invalid Date');
                }

            }
        }
    },
    dayClick: function (date, jsEvent, view) {
        var date = moment(date);

        if (date.isValid()) {
            $('#calendar').fullCalendar('renderEvent', {
                title: 'Dynamic event from date click',
                start: date,
                allDay: true
            });
        } else {
            alert('Invalid');
        }
    },
});

/*View Whats in each cell/day*/
$('#calendar').fullCalendar({
    defaultView: 'month',
    defaultDate: '2018-11-12',

    eventRender: function (eventObj, $el) {
        $el.popover({
            title: eventObj.title,
            content: eventObj.description,
            trigger: 'hover',
            placement: 'top',
            container: 'body'
        });
    },

    events: [{
        title: 'All Day Event',
        description: 'description for All Day Event',
        start: '2018-11-01'
    },
    {
        title: 'Long Event',
        description: 'description for Long Event',
        start: '2018-10-07',
        end: '2018-11-10'
    },
    {
        id: 999,
        title: 'Repeating Event',
        description: 'description for Repeating Event',
        start: '2018-11-09T16:00:00'
    },
    {
        id: 999,
        title: 'Repeating Event',
        description: 'description for Repeating Event',
        start: '2018-11-16T16:00:00'
    },
    {
        title: 'Conference',
        description: 'description for Conference',
        start: '2018-11-11',
        end: '2018-11-13'
    },
    {
        title: 'Meeting',
        description: 'description for Meeting',
        start: '2018-11-12T10:30:00',
        end: '2018-11-12T12:30:00'
    },
    {
        title: 'Lunch',
        description: 'description for Lunch',
        start: '2018-11-12T12:00:00'
    },
    {
        title: 'Meeting',
        description: 'description for Meeting',
        start: '2018-11-12T14:30:00'
    },
    {
        title: 'Birthday Party',
        description: 'description for Birthday Party',
        start: '2018-11-13T07:00:00'
    },
    {
        title: 'Click for Google',
        description: 'description for Click for Google',
        url: 'http://google.com/',
        start: '2018-11-28'
    }
    ]
});