<script lang="ts">
    import { onMount, createEventDispatcher } from 'svelte';
    import { monthes } from '../tools/formatting'

    const dispatch = createEventDispatcher();
    const monthHeight = 80;
    const year = new Date().getFullYear();

    let mnths = monthes('short').map((n, i) => {
        return {
            name: n,
            index: i,
            days: new Date(new Date(year, i + 1, 1).setDate(0)).getDate()
        };
    });
    const pointerScroll = (main, highlight) => {

        let pos = 0;
        highlight.scrollTop = 80;
        const scroll = (pos) => {
            const sPos = pos + monthHeight / 4;
            let currentMonth = Math.floor(sPos / monthHeight);
            if (currentMonth < 0) {
                dispatch("movedto", { to: new Date() });
                return;
            }
            if (currentMonth > 11) {
                dispatch("movedto", { to: new Date(year+1,1,1) });
                return;
            }
            let day = Math.floor(((sPos - currentMonth * monthHeight) / monthHeight) * mnths[currentMonth].days);
            let moveToDate = new Date(year, currentMonth, day);
            dispatch("movedto", { to: moveToDate });
        }
        main.addEventListener("scroll", e => {
            highlight.scrollTop = Math.max(monthHeight, main.scrollTop + monthHeight);
            scroll(main.scrollTop);
        })

        highlight.addEventListener("scroll", e => {
            const top = Math.max(0, highlight.scrollTop - monthHeight);
            main.scrollTop = top;
            scroll(top);
        })
    };

    onMount(() => {
        pointerScroll(
            document.getElementById('mnths-parent'),
            document.getElementById('mnths-parent-highlight')
        );
    });

</script>
<div style="position:relative;">
    <div style="overflow:auto; height:240px;" id="mnths-parent" class="no-scroll">
        <div id="mnths-child" class="user-select-none" style="cursor: pointer">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
    <div style="overflow: auto; height: 80px; position: absolute; top: 80px;" class="no-scroll" id="mnths-parent-highlight">
        <div id="mnths-child-highlight" class="user-select-none" style="cursor: pointer;">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center bg-primary text-white"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
</div>