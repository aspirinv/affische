import { defineConfig } from 'vite'
import { svelte } from '@sveltejs/vite-plugin-svelte'

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [svelte()],
    server: {        
        proxy: {
            "/api": {
                target: "https://localhost:44398",
                changeOrigin: true,
                secure: false
            },
            "/sl": "http://localhost:43396/"
        },
        cors: false,
    },
    build: {
        outDir: "../wwwroot"
    }
})
