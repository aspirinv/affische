<script lang="ts">
    import { onMount, createEventDispatcher } from 'svelte';
    import { MonthesScroll } from '../tools/monthes'

    export let position;
    let _date = new Date();
    const monthesScroll = new MonthesScroll(createEventDispatcher());
    let main;
    let highlight;

    onMount(() => {
        main = document.getElementById('mnths-parent');
        highlight = document.getElementById('mnths-parent-highlight');
        monthesScroll.attachScroll(main, highlight);
    });
    $: mobile_parent = monthesScroll.isMobile ? "overflow-auto no-scroll" : "overflow-hidden";
    $: position && positionIsChanged();

    const positionIsChanged = () => {
        if (_date != position) {
            _date = position;
            if (main && highlight) {
                let top = monthesScroll.scrollToDate(_date);
                if (top) main.scrollTop = highlight.scrollTop = top;
            }
        }
    }

</script>
<!--{ position }-->
<div style="position:relative;">
    <div style="height:240px;" id="mnths-parent" class="{mobile_parent}">
        <div id="mnths-child" class="user-select-none" style="cursor: pointer">
            <div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>
            {#each monthesScroll.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
    <div style="height: 80px; position: absolute; top: 80px;" id="mnths-parent-highlight" class="{mobile_parent}">
        <div id="mnths-child-highlight" class="user-select-none" style="cursor: pointer;">
            <!--{#if !monthesScroll.isMobile}<div class="verticaltext p-1 lh-1 fw-bold text-center" style="width:20px; height: 80px">| | <span class="fw-bolder fs-4 lh-1">↓</span></div>{/if}-->
            {#each monthesScroll.mnths as m }
            <div class="verticaltext p-1 lh-sm fw-bold text-center bg-primary text-white"
                 style="width:20px; height: 80px">{m.name}</div>
            {/each}
        </div>
        <div style="width:1px; height:160px"></div>
    </div>
</div>