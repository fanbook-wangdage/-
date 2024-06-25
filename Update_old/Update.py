import pygame
import time
import json
import requests
import wget
import tempfile
import webbrowser
import sentry_sdk

sentry_sdk.init(
    dsn="https://97c24b5be0d83a5816bdda4bd7c395be@o4506845558079488.ingest.us.sentry.io/4506845562142720",
    # Set traces_sample_rate to 1.0 to capture 100%
    # of transactions for performance monitoring.
    traces_sample_rate=1.0,
    # Set profiles_sample_rate to 1.0 to profile 100%
    # of sampled transactions.
    # We recommend adjusting this value in production.
    profiles_sample_rate=1.0,
)



temp_folder = tempfile.gettempdir()
pygame.init()
pygame.font.init()
screen_width = 450
screen_height = 400
screen = pygame.display.set_mode((450, 400))
pygame.display.set_caption("下载最新-机器人控制器")

wget.download("http://1.117.76.68/sjapp.png",temp_folder)
# 加载背景图像
background_image = pygame.image.load(temp_folder+"\\sjapp.png")

wget.download("http://1.117.76.68/gxan.png",temp_folder)
#角色
an_image = pygame.image.load(temp_folder+"\\gxan.png")
an_rect = an_image.get_rect()

an_rect.centerx = 220
an_rect.centery = 300

background_image = pygame.transform.scale(background_image, (screen_width, screen_height))
screen.blit(background_image, (0, 0))
font = pygame.font.SysFont('simsun', 10)
tplb=[]

url = "http://1.117.76.68/gx.json"
response = requests.get(url)
data = json.loads(response.text)
for i in data["gxtp"]:
    wget.download("http://1.117.76.68/"+i,temp_folder+i)
    tplb.append(pygame.image.load(temp_folder+i))
font = pygame.font.SysFont('simsun', 10)
font2 = pygame.font.SysFont('simsun', 20)
text = font.render(data["ts"], True, (0, 0, 0))
text2 = font.render(data["gxnr"], True, (0, 0, 0))
text3 = font2.render("最新版本："+str(data["V"]), True, (0, 0, 255))
print(data["ts"])
pygame.display.flip()

a=0
running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
    
    # 在屏幕上显示文本
    # 在循环中绘制
    if a==0:
        screen.fill((255, 255, 255))  # 清空屏幕
        screen.blit(background_image, (0, 0))
        screen.blit(an_image, an_rect)
        sf_image = pygame.transform.scale(tplb[0], (450, 242))
        screen.blit(sf_image,(0,0))
        screen.blit(text, (0, 350))
        screen.blit(text2, (0, 360))
        screen.blit(text3, (0, 375))
    # 在循环中绘制角色
    pygame.display.flip()
    if event.type == pygame.MOUSEBUTTONDOWN and event.button == 1:  # 检测鼠标左键点击
        mouse_x, mouse_y = pygame.mouse.get_pos()  # 获取鼠标点击位置
        if an_rect.collidepoint(mouse_x, mouse_y):  # 检测鼠标是否点击在角色矩形内
            webbrowser.open('http://file-cdn.fbwdg.dynv6.net/'+data["wj"])
            time.sleep(1.5)
pygame.quit()

