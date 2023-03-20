using Android.Views;

namespace Mopups.Droid.Gestures;

internal class MopupGestureDetectorListener : GestureDetector.SimpleOnGestureListener
{
    public event EventHandler<MotionEvent>? Clicked;

    public override bool OnSingleTapUp(MotionEvent? e)
    {
        if (e is not null) Clicked?.Invoke(this, e);

        return false;
    }
}
