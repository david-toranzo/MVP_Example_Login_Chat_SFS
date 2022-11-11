using ButtonActions;
using Installers.Core;
using UnityEngine;

public class SendMessagePresenterInstaller : MonoInstaller<SendMessagePresenter>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<IGlobalChatUseCaseMessageSender> _useCaseChatMessage;
    [SerializeField] private MonoInstaller<IGlobalChatViewMessageSender> _chatViewMessageSender;

    [Header("Presenter")]
    [SerializeField] private MonoInstaller<IButtonPresenter> _buttonPresenter;

    protected override SendMessagePresenter GetData()
    {
        return new SendMessagePresenter(_useCaseChatMessage.Data, _chatViewMessageSender.Data, _buttonPresenter.Data);
    }
}
