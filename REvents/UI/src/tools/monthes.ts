import { monthes } from './formatting'

export class MonthesScrollBridge {

    constructor(private dispatch: any) {

    }

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
        this.dispatch("movedto", { to: moveToDate });
        return sPos;
    };
}