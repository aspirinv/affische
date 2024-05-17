import { monthes } from './formatting'
import { mobileAndTabletCheck } from '../tools/utils'

export class MonthesScroll {

    constructor(private dispatch: any) {
        this.isMobile = mobileAndTabletCheck();
    }

    stopBubbling = false;
    isMobile = false;
    monthHeight = 80;
    year = new Date().getFullYear();
    mnths = monthes('short').map((n, i) => {
        return {
            name: n,
            index: i,
            days: new Date(new Date(this.year, i + 1, 1).setDate(0)).getDate()
        };
    });

    public scroll(pos: number): number {
        const sPos = pos + this.monthHeight / 4;
        let currentMonth = Math.floor(sPos / this.monthHeight);

        let day = Math.floor(((sPos - currentMonth * this.monthHeight) / this.monthHeight) * this.mnths[currentMonth].days);
        let moveToDate = new Date(this.year, currentMonth, day);

        this.stopBubbling = true;
        this.dispatch("movedto", { to: moveToDate });        
        return sPos;
    };

    public attachScroll(main: any, highlight: any) {
        if (this.isMobile) {
            this.pointerScrollMobile(main, highlight);
        } else {
            this.pointerScroll(main, highlight);
        }
    }
    public scrollToDate(date: Date) {
        if (this.stopBubbling) {
            this.stopBubbling = false;
            return null;
        }
        let p = date.getMonth() * this.monthHeight + date.getDate() * (this.monthHeight / this.mnths[date.getMonth()].days);
        console.log(date.getDate(), this.mnths[date.getMonth()].days, p);
        return p;
    }

    private pointerScroll(main: any, highlight: any) {
        let isDrag = false;
        let pos = 0;
        const dragStart = () => isDrag = true;
        const dragEnd = () => isDrag = false;
        const drag = (ev) => {
            if (!isDrag) return;
            pos -= ev.movementY;
            pos = Math.max(0, pos);
            main.scrollTop = pos;
            highlight.scrollTop = Math.max(0, pos);

            this.scroll(pos);
        }

        main.addEventListener("pointerdown", dragStart);
        highlight.addEventListener("pointerdown", dragStart);
        addEventListener("pointerup", dragEnd);
        addEventListener("pointermove", drag);
    };

    private pointerScrollMobile(main: any, highlight: any) {
        console.log("Mobile scroll");
        main.addEventListener("scroll", e => {
            console.log("Main scroll");
            highlight.scrollTop = Math.max(0, main.scrollTop);
            this.scroll(main.scrollTop);
        })

        highlight.addEventListener("scroll", e => {
            const top = Math.max(0, highlight.scrollTop);
            main.scrollTop = top;
            this.scroll(top);
        })
    };

}