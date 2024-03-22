<script lang="ts">
    import { onMount, createEventDispatcher } from 'svelte';
    import { MonthesScrollBridge } from '../tools/monthes'

    export let position;

    const monthesBridge = new MonthesScrollBridge(createEventDispatcher());

    const pointerScroll = (main, highlight) => {
        let isDrag = false;
        let pos = 0;
        highlight.scrollTop = monthesBridge.monthHeight;
        const dragStart = () => isDrag = true;
        const dragEnd = () => isDrag = false;
        const drag = (ev) => {
            if (!isDrag) return;
            pos -= ev.movementY;
            pos = Math.max(0, pos);
            main.scrollTop = pos;
            highlight.scrollTop = Math.max(monthesBridge.monthHeight, pos + monthesBridge.monthHeight);

            monthesBridge.scroll(pos);
        }

        main.addEventListener("pointerdown", dragStart);
        highlight.addEventListener("pointerdown", dragStart);
        addEventListener("pointerup", dragEnd);
        addEventListener("pointermove", drag);
    };

    onMount(() => {
        pointerScroll(
            document.getElementById('mnths-parent'),
            document.getElementById('mnths-parent-highlight')
        );
    });

</script>
{ position }
<div style="position:relative;">
    <div style="overflow:hidden; height:240px;" id="mnths-parent">
        <div id="mnths-child" class="user-select-none" style="cursor: pointer">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each monthesBridge.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
    <div style="overflow: hidden; height: 80px; position: absolute; top: 80px;" id="mnths-parent-highlight">
        <div id="mnths-child-highlight" class="user-select-none" style="cursor: pointer;">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each monthesBridge.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center bg-primary text-white"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
</div>