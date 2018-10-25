from datetime import datetime
# To determine DST/summertime
#  Portland: US/Pacific
#  New York: US/Eastern
#  London:   Europe/London
import pytz 

def start():

    # set timezone
    portland = set_timezone('US/Pacific')
    newyork = set_timezone('US/Eastern')
    london = set_timezone('Europe/London')

    # get local time in Portland
    dt = portland.localize(datetime.now())

    # check branches and return results
    check_branch(dt, newyork, "New York City")
    check_branch(dt, london, "London")

def set_timezone(strTimezone): 
    timezone = pytz.timezone(strTimezone)
    return timezone

def check_branch(dt, timezone, city):

    dtLocal = dt.astimezone(timezone)
    dtOpen = dtLocal.replace(hour = 9, minute = 0, second = 0, microsecond = 0)
    dtClose =  dtLocal.replace(hour = 21, minute = 0, second = 0, microsecond = 0)

    if dtLocal >= dtOpen and dtLocal < dtClose:
        sOpen = "open"
    else:
        sOpen = "closed"

    print "\n" + city + " branch is " + sOpen + "."
    print "Local time in " + city + ": " + dtLocal.strftime("%Y-%m-%d %H:%M")

if __name__ == "__main__":
    start()
